using BE;
using BL;
using PL.Models;
using PL.Views;
using SHYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewsModels
{
    public class CaloriesVM
    {
        public List<CaloriesModel> Data { get; set; }
        public CaloriesModel Model { get; set; }
        public CaloriesUC CaloriesUC { get; set; }
        public User User { get; set; }
        public Bl MyBL { get; set; }
        public CaloriesVM(CaloriesUC caloriesUC)
        {
            Model = new CaloriesModel();
            CaloriesUC = caloriesUC;

            MyBL = new Bl();
            User = ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.CurrentModel.CurrentUser;

            Data = new List<CaloriesModel>();
            var Calories = MyBL.GetAllTotalCaloriesList(User.Id);


            foreach (var c in Calories)
            {
                Data.Add(new CaloriesModel { Date = c.Key, TotalCalories = c.Value });
            }

        }
    }
}
