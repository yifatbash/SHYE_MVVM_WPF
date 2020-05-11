using BE;
using PL.Commands;
using PL.Models;
using SHYE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PL.ViewsModels
{
    public class AddFoodVM : DependencyObject, INotifyPropertyChanged
    {
        public AddFoodUC FoodUC { get; set; }
        public AddFoodModel Model { get; set; }
        public ObservableCollection<BE.Food> Foods { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public CompleteCommand ApiCommand { get; set; }
        public ReplaceUCCommand ReplaceViewCommand { get; set; }

        public AddFoodVM(AddFoodUC foodUC)
        {
            Model = new AddFoodModel();

            ApiCommand = new CompleteCommand();
            ApiCommand.callComplete += ApiCommand_callComplete;

            ReplaceViewCommand = new ReplaceUCCommand();
            ReplaceViewCommand.ReplaceUserControl += ReplaceViewCommand_Back;

            Foods = new ObservableCollection<BE.Food>(Model.FoodList);
            Foods.CollectionChanged += Foods_CollectionChanged;
            FoodUC = foodUC;
        }

        #region class Funcs
        private void ApiCommand_callComplete()
        {
            //get food details
            Food completeFood = Model.getApiFoodDetails(FoodUC.foodName.Text, double.Parse(FoodUC.foodAmount.Text));
            Model.MyFood = completeFood;

            //add to DB
            Model.saveMeal();

            //--UPDATE THE VIEW--
            InitFoodList();
            //update the food list view
            //FoodTemplateUC foodDetails = new FoodTemplateUC();
            //foodDetails.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            //foodDetails.DataContext = Model.MyFood;
            //FoodUC.foodListView.Items.Add(foodDetails);

            //clean the search fields
            FoodUC.foodName.Text = "";
            FoodUC.foodAmount.Text = "";
        }

        #endregion

        internal void InitFoodList()
        {
            List<BE.Food> foodList = new List<BE.Food>();
            foodList = Model.GetFoodList(Model.MyMeal.MealType, Date).ToList();
            addToCollection(Foods, foodList);
        }

        /// <summary>
        /// intialization and add all food in new date 
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="lst"></param>
        public void addToCollection(ObservableCollection<BE.Food> collection, List<BE.Food> lst)
        {
            int counter = collection.Count;
            for (int i = counter; i > 0; i--)
            {
                collection.Remove(collection[i - 1]);
            }
            if (lst.Count != 0)
            {
                foreach (BE.Food Item in lst)
                {
                    collection.Add(Item);
                }
            }
        }
        private void Foods_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                //הוספה
                BE.Food f = e.NewItems[0] as BE.Food;
                //if (f.ID == Id)
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

        private void ReplaceViewCommand_Back(string obj)
        {
            ChooseMealUC view = new ChooseMealUC();
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(view);
        }

        public void SetMealType(String mealType)
        {
            switch (mealType)
            {
                case "Breakfast":
                    Model.MyMeal.MealType = MealType.Breakfast;
                    break;
                case "Lunch":
                    Model.MyMeal.MealType = MealType.Lunch;
                    break;
                case "Dinner":
                    Model.MyMeal.MealType = MealType.Dinner;
                    break;
                case "Snacks":
                    Model.MyMeal.MealType = MealType.Snacks;
                    break;
                default:
                    break;
            }
        }


        #region Class Fields

        public DateTime Date
        {
            get { return Model.MyMeal.Date; }
            set
            {
                Model.MyMeal.Date = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
            }
        }
        //public BE.MealType MealType
        //{
        //    get { return Model.MyMeal.MealType; }
        //    set
        //    {
        //        Model.MyMeal.MealType = value;
        //        if (PropertyChanged != null)
        //            PropertyChanged(this, new PropertyChangedEventArgs("MealType"));
        //    }
        //}
        public string Name
        {
            get { return Model.MyMeal.FoodName; }
            set
            {
                Model.MyMeal.FoodName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public double Amount
        {
            get { return Model.MyMeal.Amount; }
            set
            {
                Model.MyMeal.Amount = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Amount"));
            }
        }

        #endregion




    }
}
