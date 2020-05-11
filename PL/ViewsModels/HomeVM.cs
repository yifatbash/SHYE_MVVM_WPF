using PL.Commands;
using PL.Views;
using SHYE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PL.ViewsModels
{
    public class HomeVM
    {
        public HomeVM(HomeUC homeUc)
        {
            this.HomeUC = homeUc;
            ReplaceCommand = new ReplaceUCCommand();
            ReplaceCommand.ReplaceUserControl += MyReplaceCommand_ReplaceUserControl;
        }

        #region Class Fields
        private HomeUC HomeUC;
        public ReplaceUCCommand ReplaceCommand { get; set; }
        #endregion

        #region Class Funcs
        private void MyReplaceCommand_ReplaceUserControl(string obj)
        {
            ((MainWindow)Application.Current.MainWindow).mainGrid.Children.Remove(HomeUC);

        }
        #endregion
    }
}
