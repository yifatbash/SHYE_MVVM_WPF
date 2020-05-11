using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    /// <summary>
    /// All of our accesses to data,api and database
    /// </summary>
    public class Dal
    {
        #region User Funcs
        public bool CheckExistUser(string email)
        {
            using (var db = new SHYEContext())
            {
                var query = from u in db.Users
                            where u.Email == email
                            select u;
                foreach (var item in query)
                {
                    return true;//if we entered here there are items in query,user exist
                }
                return false;
            }
        }

        public void updateUser(User updatedUser)
        {
            using (var db = new SHYEContext())
            {
                //update user record
                db.Entry(updatedUser).State = EntityState.Modified;

                //Update the BMIs table
                UpdateBMI(updatedUser);

                db.SaveChanges();
            }
        }

        private void UpdateBMI(User updatedUser)
        {
            using (var db = new SHYEContext())
            {
                //Update the BMIs
                BMI bmi = new BMI()
                {
                    UserId = updatedUser.Id,
                    Height = (float)updatedUser.Height,
                    Weight = (float)updatedUser.Weight,
                    Date = DateTime.Today
                };
                //search if today is already exist in bmi table
                var query = from b in db.BMIs
                            where DbFunctions.TruncateTime(b.Date) == DateTime.Today && b.UserId == updatedUser.Id
                            select b;
                
                //delete if it was already exist
                if (query.Count() != 0)
                {
                    db.Entry(bmi).State = EntityState.Modified;
                }
                else
                {
                    db.BMIs.Add(bmi);
                }
                db.SaveChanges();
            }
        }

        public User findUserByLogin(string email, string password)
        {
            using (var db = new SHYEContext())
            {
                var query = from u in db.Users
                            where u.Email == email && u.Password == password
                            select u;
                foreach (var item in query)
                {
                    return item;//if we entered here there are items in query,user exist
                }
                return null;
            }
        }

        public void addNewUser(User user, WeeklyGoal goal,BMI bMI)
        {
            using (var db = new SHYEContext())
            {
                db.Users.Add(user);
                db.Goals.Add(goal);
                db.BMIs.Add(bMI);

                db.SaveChanges();
            }
        }

        public List<BMI> GetWeight(int UserId)
        {
            using (var db = new SHYEContext())
            {
                var q = from w in db.BMIs
                        where w.UserId == UserId
                        select w;
                var weight = q.ToList();
                return weight;

            }
        }


        #endregion


        #region Food Funcs
        //return all food details in the mealType (according to date & user)
        public IEnumerable<Food> GetFoodList(MealType mealType, DateTime date, int userId)
        {
            IEnumerable<Meal> MealList = GetMealList(mealType, date, userId);
            List<Food> FoodList = new List<Food>();

            if (MealList == null)
                return FoodList;

            using (var db = new SHYEContext())
            {
                foreach (var meal in MealList)
                {
                    {
                        var query = from f in db.Foods
                                    where f.Name == meal.FoodName
                                    select f;
                        //chenge from per 100g to the real amount
                        var food = query.FirstOrDefault<Food>();
                        if (food != null)
                        {
                            food.Calories *= (float)meal.Amount/100;
                            food.Carbs *= (float)meal.Amount/100;
                            food.Proteins *= (float)meal.Amount/100;
                            food.Fats*= (float)meal.Amount/100;

                            food.Proteins = (float)System.Math.Round((double)food.Proteins, 2);
                            food.Calories = (float)System.Math.Round((double)food.Calories, 2);
                            food.Carbs = (float)System.Math.Round((double)food.Carbs, 2);
                            food.Fats = (float)System.Math.Round((double)food.Fats, 2);
                        }
                        FoodList.Add(food);
                    }
                }
            }
            return FoodList;
        }

        public Food getApiFoodDetails(string foodName)
        {
            string AsckFoodKey = @"https://api.nal.usda.gov/ndb/search/?format=JSON&q=" + foodName + "&sort=n&max=25&offset=0&api_key=" + "iFjZG9JHsryEhpdo9qfprQVFg2HM3faohPZ00O4Y";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AsckFoodKey);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd(); //Json format

            JObject responsJ = JObject.Parse(responsereader);

            IEnumerable<JToken> responsJItems = responsJ["list"]["item"];//.Where(temp => temp["name"].ToString().Contains("BREAKFAST")).Select(temp => temp);
            
            //we take just first answer,TODO: auto complete
            string keyFood = responsJItems.First<JToken>()["ndbno"].ToString(); //the key-num of corunty branded
            string AsckFoodComponents = @"https://api.nal.usda.gov/ndb/V2/reports?ndbno=" + keyFood + "&type=b&format=JSON&api_key=" + "iFjZG9JHsryEhpdo9qfprQVFg2HM3faohPZ00O4Y";
            request = (HttpWebRequest)WebRequest.Create(AsckFoodComponents);
            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            sreader = new StreamReader(dataStream);
            responsereader = sreader.ReadToEnd();

            //value per 100g
            JObject responsJFoodDetails = JObject.Parse(responsereader);

            float? calories = getNutrientsValue(responsJFoodDetails, "Energy");
            float? carbs = getNutrientsValue(responsJFoodDetails, "Carbohydrate, by difference");
            float? protein = getNutrientsValue(responsJFoodDetails, "Protein");
            float? fats = getNutrientsValue(responsJFoodDetails, "Total lipid (fat)");

            //food name by output
            //string name = responsJItems.First<JToken>()["name"].ToString();
            //Food newFood = new Food() {Name = name, Calories = calories, Carbs = carbs, Proteins = protein, Fats = fats };
            //food name by input
            Food newFood = new Food() { Name = foodName, Calories = calories, Carbs = carbs, Proteins = protein, Fats = fats };
            return newFood;
        }

        private float? getNutrientsValue(JObject responsJFoodDetails, string wantedNutrient)
        { 
            IEnumerable<JToken> responsJk = responsJFoodDetails["foods"][0]["food"]["nutrients"].Where(temp => temp["name"].ToString().Contains(wantedNutrient)).Select(temp => temp["value"]).First<JToken>();
            //responsJk = responsJk.Where(temp => temp["unit"].ToString().Contains("g")).Select(temp => temp["value"]).First<JToken>();//=מידה measure
            string value = responsJk.ToString();
            return float.Parse(value);
        }

        public Food GetApiFoodDetailsFromDB(string foodName)
        {
            using (var db = new SHYEContext())
            {
                var query = from f in db.Foods
                            where f.Name == foodName
                            select f;
                return query.FirstOrDefault();
            }
        }

        /// <summary>
        /// save the food with it's values per 100g
        /// </summary>
        /// <param name="food"></param>
        public void saveFood(Food food)
        {
            using (var db = new SHYEContext())
            {
                db.Foods.Add(food);
                db.SaveChanges();
            }
        }

        public bool checkExistFood(string foodName)
        {
            using (var db = new SHYEContext())
            {
                var query = from f in db.Foods
                            where f.Name == foodName
                            select f;
                foreach (var item in query)
                {
                    return true;
                }
                return false;
            }
        }

        private IEnumerable<Meal> GetAllMeals(int userId, DateTime date)
        {

            IEnumerable<Meal> MealList = new List<Meal>();

            var Meals = Enum.GetValues(typeof(MealType)).Cast<MealType>();

            foreach (var t in Meals)
            {
                MealList = MealList.Concat(GetMealList(t, date, userId)).ToList();
            }

            return MealList;
        }
        //for the summary
        public Dictionary<String, float> GetTotalNutrients(int userId, DateTime date)
        {
            //create new dictionary
            IEnumerable<String> Nutrients = new List<string>() { "Carbs", "Fats", "Proteins","Calories"};
            Dictionary<String, float> totalDic = new Dictionary<string, float>();

            foreach (var n in Nutrients)
            {
                totalDic.Add(n, 0);
            }

            //go over the meals and som the nutrients values
            IEnumerable<Meal> MealList = GetAllMeals(userId, date);
            using (var db = new SHYEContext())
            {
                foreach (var m in MealList)
                {
                    var query= from f in db.Foods
                               where f.Name == m.FoodName
                               select f;
                    var food = query.FirstOrDefault();
                    if (food != null)
                    {
                        totalDic["Carbs"] += (float)food.Carbs * (float)m.Amount/100;
                        totalDic["Fats"] += (float)food.Fats * (float)m.Amount/100;
                        totalDic["Proteins"] += (float)food.Proteins * (float)m.Amount/100;
                        totalDic["Calories"] += (float)food.Calories * (float)m.Amount/100;
                    }
                    

                }
            }

            return totalDic;
        }

        //return list of all total calories of the user, for each day
        public Dictionary<DateTime, int> GetAllTotalCaloriesList(int userId)
        {
            Dictionary<DateTime, int> total = new Dictionary<DateTime, int>();

            using (var db = new SHYEContext())
            {
                //collect all the days user enter food 
                var q = from m in db.Meals
                        where m.UserId == userId
                        group m by DbFunctions.TruncateTime(m.Date) into d
                        select d.Key;

                if(q!=null)
                {
                    var dates = q.ToList();
                    //calc total calories for each day
                    
                    if (dates != null)
                    {
                        foreach (var d in dates)
                        {
                            total.Add((DateTime)d, (int)GetTotalNutrients(userId, (DateTime)d)["Calories"]);
                        }
                    }
                    return total;
                }

                return total;

            }
        }
        #endregion

        #region WeeklyGoal Funcs
        public WeeklyGoal GetCurrentGoal(User user)
        {
            WeeklyGoal goal = new WeeklyGoal();
            using (var db = new SHYEContext())
            {
                var query = from g in db.Goals
                            where g.UserId == user.Id
                            orderby g.Date descending
                            select g;
                if(query != null)
                    goal = query.FirstOrDefault();

                return goal;
            }
            

        }

        public WeeklyGoal GetDateUserWeeklyGoal(int userId, DateTime date)
        {
            using (var db = new SHYEContext())
            {
                var query = from g in db.Goals
                            where g.UserId == userId && DbFunctions.TruncateTime(g.Date) == date
                            select g;
                return query.FirstOrDefault<WeeklyGoal>();
            }
        }

        public void SaveWeeklyGoal(WeeklyGoal goal)
        {
            using (var db = new SHYEContext())
            {
                WeeklyGoal myGoal = getWeekIfExist(goal.UserId);
                if (myGoal != null)
                {
                    //update goal
                    db.Entry(goal).State = EntityState.Modified;
                }
                else
                {
                    db.Goals.Add(goal);
                }

                db.SaveChanges();
            }
        }

        public WeeklyGoal getWeekIfExist(int userId)
        {
            using (var db = new SHYEContext())
            {
                var query = from g in db.Goals
                            where g.UserId == userId 
                            select g;
                foreach (var item in query)
                {
                    return item;
                }
                return null;
            }
        }
        #endregion

        #region Meal Funcs

        //return list of food names and amount in that mealType (according to date and user) 
        private IEnumerable<Meal> GetMealList(MealType mealType, DateTime date, int userId)
        {

            using (var db = new SHYEContext())
            {
                var query = from m in db.Meals
                            where m.UserId == userId && DbFunctions.TruncateTime(m.Date) == date.Date && m.MealType == mealType
                            select m;
                List<Meal> foods = query.ToList<Meal>();
                return foods;
            }
        }

        //update the amount of some food or add new record
        public void saveMeal(Meal meal)
        {
            var amount = CheckExistMeal(meal);

            if (amount != null)//exist
            {
                meal.Amount += (double) amount;
                using (var db = new SHYEContext())
                {
                    //update meal
                    db.Entry(meal).State = EntityState.Modified;
                    db.SaveChanges();
                    return;
                }
            }

            using (var db = new SHYEContext())//not exist
            {
                db.Meals.Add(meal);
                db.SaveChanges();
            }
        }

        //return the amount
        public Double? CheckExistMeal(Meal meal)
        {
            using (var db = new SHYEContext())
            {
                var q = from f in db.Meals
                        where f.FoodName == meal.FoodName && f.MealType == meal.MealType && DbFunctions.TruncateTime(f.Date) == meal.Date.Date && f.UserId == meal.UserId
                        select f;
                var food = q.FirstOrDefault();
                if (food != null)
                    return food.Amount;
                else
                    return null;
            }
        }
        #endregion


    }
}
