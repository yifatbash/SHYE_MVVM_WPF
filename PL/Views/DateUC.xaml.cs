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

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour DateUC.xaml
    /// </summary>
    public partial class DateUC : UserControl
    {
        public DateVM MyDateVM { get; set; }
        public RegisterVM regVM { get; set; }
        //public WeeklyGoalVM weekVM { get; set; }

        public DateUC(RegisterVM regVm)
        {
            InitializeComponent();
            this.regVM = regVm;
            MyDateVM = new DateVM(this, regVm);
            this.DataContext = MyDateVM;
        }

    }
}
