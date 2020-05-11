using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Bl
    {
        public Dal MyDal { get; set; }
        public Bl()
        {
            MyDal = new Dal();
        }

        #region User Funcs
        /// <summary>
        /// check if a user exist in database
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckExistUser(string email)
        {
            return MyDal.CheckExistUser(email);
        }

        /// <summary>
        /// update user details in database 
        /// </summary>
        /// <param name="newUser"></param>
        public void updateUser(User newUser)
        {
            MyDal.updateUser(newUser);
        }

        /// <summary>
        /// after user used the login form we found him in database and return his details
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User findUserByLogin(string email, string password)
        {
            return MyDal.findUserByLogin(email, password);
        }

        /// <summary>
        /// add new user to database after register 
        /// </summary>
        /// <param name="user"></param>
        public void addNewUser(User user, WeeklyGoal goal)
        {
            CalcWeeklyGoal(goal);
            BMI bMI = new BMI()
            {
                User=user,
                Height=(float)user.Height,
                Weight=(float)user.Weight,
                Date=DateTime.Now,
            };

            MyDal.addNewUser(user,goal,bMI);
        }

        public List<BMI> GetWeight(int UserId)
        {
            return MyDal.GetWeight(UserId);
        }
        #endregion

        #region Food Funcs
        /// <summary>
        /// return all foods that a user ate in a meal at specific date
        /// </summary>
        /// <param name="mealType"></param>
        /// <param name="date"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<Food> GetFoodList(MealType mealType, DateTime date, int userId)
        {
            return MyDal.GetFoodList(mealType, date.Date, userId);
        }

        /// <summary>
        /// save new food in database (if it doesn't exist in db),after user inserted it to a meal
        /// </summary>
        /// <param name="food"></param>
        public void saveFood(String foodName)
        {
            bool isExist = MyDal.checkExistFood(foodName);
            if (!isExist)
            {
                Food perHundredGram = MyDal.getApiFoodDetails(foodName);
                perHundredGram.Proteins = (float)System.Math.Round((double)perHundredGram.Proteins, 2);
                perHundredGram.Calories = (float)System.Math.Round((double)perHundredGram.Calories, 2);
                perHundredGram.Carbs = (float)System.Math.Round((double)perHundredGram.Carbs, 2);
                perHundredGram.Fats = (float)System.Math.Round((double)perHundredGram.Fats, 2);
                MyDal.saveFood(perHundredGram);
            }         
        }

        /// <summary>
        /// save meal in database after user added connected food
        /// </summary>
        /// <param name="meal"></param>
        public void saveMeal(Meal meal)
        {
            saveFood(meal.FoodName);

            MyDal.saveMeal(meal);
        }

        /// <summary>
        /// get nutrients of food from usda api or from DB
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="countValue"></param>
        /// <returns></returns>
        public Food getApiFoodDetails(string foodName, double countValue)
        {
            Food perHundredGram = new Food();

            bool isExist = checkExistFood(foodName);
            if (isExist)
            {
                perHundredGram = MyDal.GetApiFoodDetailsFromDB(foodName);
            }
            else
            {
                perHundredGram = MyDal.getApiFoodDetails(foodName);
            }
 
            if (countValue != 100)//api calc values per 100 gram if user chose in slider another value we calc it
            {
                perHundredGram.Fats = (float?)(perHundredGram.Fats * (countValue/100));
                perHundredGram.Proteins = (float?)(perHundredGram.Proteins * (countValue/100));
                perHundredGram.Calories = (float?)(perHundredGram.Calories * (countValue/100));
                perHundredGram.Carbs = (float?)(perHundredGram.Carbs * (countValue/100));
            }
            return perHundredGram;
        }

        /// <summary>
        /// check if a food exist in the database. //if it doesnt exist we will use our func-"save food"
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public bool checkExistFood(String foodName)
        {
            return MyDal.checkExistFood(foodName);
        }
        #endregion

        #region Options Funcs
        public Dictionary<String, int> GetTotalNutrients(int userId, DateTime date)
        {
            var floatDic = MyDal.GetTotalNutrients(userId, date);
            Dictionary<String, int> intDic = new Dictionary<string, int>();
            foreach ( var v in floatDic)
            {
                intDic.Add(v.Key, (int)Math.Round(v.Value));
            }
            return intDic;

        }

        /// <summary>
        /// calc bmi of user by his weight and height
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public float? calculateBMI(User user)
        {
            if (!user.Height.ToString().Contains("."))
                user.Height = user.Height / 100;
            double bmi = (double)(user.Weight / (user.Height * user.Height));
            return (float?)(float)System.Math.Round(bmi, 2); ;
        }

         #endregion

        #region Weekly Goal Funcs
        private void CalcWeeklyGoal(WeeklyGoal goal)
        {
            goal.Carbs = (float)System.Math.Round((0.55 * goal.WantedCalories) / 4, 2);
            goal.Fats = (float)System.Math.Round((0.25 * goal.WantedCalories) / 9, 2);
            goal.Proteins = (float)System.Math.Round((0.2 * goal.WantedCalories) / 4, 2); 
        }

        public int CalcRemainingCalories(User user, DateTime date)
        {
            var totalCal = GetCurretWeeklyGoal(user).WantedCalories;
            var eatenCal = GetTotalNutrients(user.Id, date)["Calories"];
            return (int)totalCal - eatenCal;
        }

        public WeeklyGoal GetCurretWeeklyGoal(User user)
        {
            return MyDal.GetCurrentGoal(user);
        }
        
       
        /// <summary>
        /// save new weekly goal in database
        /// </summary>
        /// <param name="myWeeklyGoal"></param>
        public void SaveWeeklyGoal(WeeklyGoal myWeeklyGoal)
        {
            CalcWeeklyGoal(myWeeklyGoal);
            MyDal.SaveWeeklyGoal(myWeeklyGoal);
        }
        #endregion

        public Dictionary<DateTime, int> GetAllTotalCaloriesList(int userId)
        {
            return MyDal.GetAllTotalCaloriesList(userId);
        }
    }
}
