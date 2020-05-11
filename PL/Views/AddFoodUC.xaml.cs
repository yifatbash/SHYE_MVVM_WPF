using BE;
using PL.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SHYE
{
    /// <summary>
    /// Interaction logic for AddFoodUC.xaml
    /// </summary>
    public partial class AddFoodUC : UserControl
    {
        public AddFoodVM FoodVM;

        public AddFoodUC(String mealType="")
        {
            InitializeComponent();
            FoodVM = new AddFoodVM(this);
            FoodVM.SetMealType(mealType);

            chosenDate.SelectedDate = DateTime.Today; //TODAY as default
            FoodVM.Model.MyMeal.Date = (DateTime)chosenDate.SelectedDate;

            this.DataContext = FoodVM;
        }

        private void foodName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(foodName.Text!="" && foodAmount.Text!="")
            {
                addButton.IsEnabled = true;
            }
            else
            {
                addButton.IsEnabled = false;
            }
        }

        private void foodAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (foodName.Text != "" && foodAmount.Text != "")
            {
                addButton.IsEnabled = true;
            }
            else
            {
                addButton.IsEnabled = false;
            }
        }

        //update the food list of the selected date
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            FoodVM.Model.MyMeal.Date = (DateTime)chosenDate.SelectedDate;
            FoodVM.InitFoodList();

        }
    }
}
