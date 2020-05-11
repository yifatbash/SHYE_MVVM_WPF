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

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for CaloriesUC.xaml
    /// </summary>
    public partial class CaloriesUC : UserControl
    {
        public CaloriesVM CaloriesVM;
        public CaloriesUC()
        {
            InitializeComponent();
            CaloriesVM = new CaloriesVM(this);
            DataContext = CaloriesVM;

            int thisMonth = DateTime.Today.Month;
            int thisYear = DateTime.Today.Year;

            DateAxis.Minimum = new DateTime(thisYear, thisMonth, 1);
            DateAxis.Maximum = new DateTime(thisYear, thisMonth, DateTime.DaysInMonth(thisYear, thisMonth));

            SfChart chart = new SfChart();
            ColumnSeries series = new ColumnSeries()
            {
                EnableAnimation = true,
                AnimationDuration = new TimeSpan(00, 00, 07)
            };

            series.ShowTooltip = true;
            chart.Series.Add(series);

        }

    }
}
