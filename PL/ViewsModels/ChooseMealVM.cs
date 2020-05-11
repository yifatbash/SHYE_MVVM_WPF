using SHYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PL.ViewsModels
{
    public class ChooseMealVM
    {
        public string Title { get; set; }
        public string ImageUri { get; set; }
        public int Percentage { get; set; }
        public ReplaceUCCommand ReplaceViewCommand { get; set; }

        public ChooseMealVM(ChooseMealUC meal)
        {
            ReplaceViewCommand = new ReplaceUCCommand();
            ReplaceViewCommand.ReplaceUserControl += MyReplaceUCCommand_ChooseMeal;
        }

        private void MyReplaceUCCommand_ChooseMeal(string obj)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
            AddFoodUC view = new AddFoodUC(obj);
            view.mealType.Text = obj;
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(view);

        }

    }
}
