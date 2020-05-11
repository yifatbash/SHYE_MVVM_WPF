using PL.ViewsModels;
using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
//using Syncfusion.SfChart.XForms;

namespace PL.Views
{
    /// <summary>
    /// Interaction logic for WeightGraphUC.xaml
    /// </summary>
    public partial class WeightGraphUC : UserControl
    {
        public WeightEvaluationVM WeightVM; 
        public WeightGraphUC()
        {
            InitializeComponent();
            WeightVM = new WeightEvaluationVM(this);
            DataContext = WeightVM;

            int thisMonth = DateTime.Today.Month;
            int thisYear = DateTime.Today.Year;

            DateAxis.Minimum = new DateTime(thisYear, thisMonth, 1);
            DateAxis.Maximum = new DateTime(thisYear, thisMonth, DateTime.DaysInMonth(thisYear, thisMonth));

            SfChart chart = new SfChart();

            FastLineSeries fastSeries = new FastLineSeries()
            {
                EnableAnimation = true,
                AnimationDuration = new TimeSpan(00, 00, 05)
            };

            fastSeries.ShowTooltip = true;
            chart.Series.Add(fastSeries);

            //ColumnSeries series = new ColumnSeries()
            //{
            //    AnimationDuration = new TimeSpan(00, 00, 03)
            //};
            
            //series.ShowTooltip = true;
            //chart.Series.Add(series);

        }
    }
}
