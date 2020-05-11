using BE;
using PL.Models;
using SHYE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PL.ViewsModels
{
    class MealVM: DependencyObject
    {
        MealModel Model { get; set; }
        public String Name { get; set; }
        public ObservableCollection<BE.Food> FoodList { get; set; }
        public MealVM(AddFoodUC foodUC)
        {
            Model = new MealModel();

            Model.MyMeal.Date = (DateTime)foodUC.chosenDate.SelectedDate;
            string mealType = foodUC.mealType.Text;
            switch (mealType)
            {
                case "Breakfast":
                    Model.MyMeal.MealType = BE.MealType.Breakfast;
                    break;
                case "Lunch":
                    Model.MyMeal.MealType = BE.MealType.Lunch;
                    break;
                case "Dinner":
                    Model.MyMeal.MealType = BE.MealType.Dinner;
                    break;
                default:
                    break;
            }

            FoodList = new ObservableCollection<BE.Food>(Model.FoodList);
            FoodList.CollectionChanged += Foods_CollectionChanged;
        }

        private void Foods_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                //הוספה
                BE.Food f = e.NewItems[0] as BE.Food;
 //               if (f.ID == Id)
                {
                    Model.FoodList.Add(e.NewItems[0] as BE.Food);
                }
            }
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                //הסרה
                BE.Food f = e.OldItems[0] as BE.Food;
                //if (f.ID == Id)
                {
                    Model.FoodList.Remove(f);
                }
            }
        }

        public void GetFoodList(MealType type, DateTime date, int UserId)
        {
          
        }
    }
}
