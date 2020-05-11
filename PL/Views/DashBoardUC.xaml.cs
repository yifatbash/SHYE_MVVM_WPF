using PL.ViewsModels;
using Syncfusion.UI.Xaml.Charts;
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

namespace PL
{
    /// <summary>
    /// Logique d'interaction pour DashBoardUC.xaml
    /// </summary>
    public partial class DashBoardUC : UserControl
    {

        public DashboardVM DashboardVM;
        public DashBoardUC()
        {
            InitializeComponent();
            DashboardVM = new DashboardVM(this);
            this.DataContext = DashboardVM;
            

        }
    }
}
