using PL.Models;
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
    /// Interaction logic for AddMealUC.xaml
    /// </summary>
    public partial class AddMealUC : UserControl
    {
        public string Title { get; set; }
        public string ImageUri { get; set; }
        public int Percentage { get; set; }

        public AddMealUC()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
