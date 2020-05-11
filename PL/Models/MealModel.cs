using BL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PL.Models
{
    class MealModel
    {
        public Bl MyBl { get; set; }
        public Meal MyMeal { get; set; }
        public List<BE.Food> FoodList { get; set; }
        public MealModel()
        {
            FoodList = MyBl.GetFoodList(MyMeal.MealType, MyMeal.Date, MyMeal.UserId).ToList();
        }

    }
}
