using BE;
using BL;
using SHYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PL.Models
{
    public class AddFoodModel
    {
        public User User { get; set; }
        private Bl MyBl { get; set; }
        public Food MyFood { get; set; }
        public Meal MyMeal { get; set; }
        public List<BE.Food> FoodList { get; set; }
  
        public AddFoodModel()
        {
            User = ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.CurrentModel.CurrentUser;
            MyBl = new Bl();
            MyFood = new Food();
            MyMeal = new Meal();
            MyMeal.UserId = User.Id;
            FoodList = new List<Food>();
        }

        internal void saveMeal()
        {
            MyBl.saveMeal(MyMeal);
        }

        internal List<Food> GetFoodList(MealType mealType, DateTime date)
        {
           return MyBl.GetFoodList(mealType, date, User.Id).ToList();
        }

        internal Food getApiFoodDetails(string text, double grams)
        {
            try
            {
                return MyBl.getApiFoodDetails(text, grams);
            }
            catch (Exception e)
            {

                MessageBox.Show("Problem with getting data about this food", "wrong food details", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }


    }
}
