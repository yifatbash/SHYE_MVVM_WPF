using PL;
using PL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SHYE
{
    public class MenuVM
    {
        public ReplaceUCCommand ReplaceViewCommand { get; set; }

        public MenuVM(MenuUC menu)
        {
            ReplaceViewCommand = new ReplaceUCCommand();
            ReplaceViewCommand.ReplaceUserControl += MyReplaceUCCommand_ReplaceUserControl;
        }

        private void MyReplaceUCCommand_ReplaceUserControl(string obj)
        {
            UserControl view = null;

            switch (obj)
            {
                case "PROFIL":
                    {
                        view = new ProfileUC();
                        break;
                    }
                case "DASHBOARD":
                    {
                        view = new DashBoardUC();
                        break;
                    }
                case "DAIRY":
                    {
                        view = new ChooseMealUC();
                        break;
                    }

            }


                    ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(view);


        }
    }
}
