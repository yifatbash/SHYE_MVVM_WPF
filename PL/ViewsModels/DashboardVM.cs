using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewsModels
{
    public class DashboardVM
    {
        private DashBoardUC DashboardUC;
        public DashboardModel Model { get; set; }

        public DashboardVM(DashBoardUC dashboardUC)
        {
            Model = new DashboardModel();
            DashboardUC = dashboardUC;

            //set the summary box
            DashboardUC.actualCrabs.Text = Model.ActualFood["Carbs"].ToString();
            DashboardUC.actualFat.Text = Model.ActualFood["Fats"].ToString();
            DashboardUC.actualProtein.Text = Model.ActualFood["Proteins"].ToString();

            int RemainingCalories = CalcRemaining();
            DashboardUC.remainingValue.Text = RemainingCalories.ToString();
            DashboardUC.remainingProgress.Progress = (int)Model.Goal.WantedCalories - RemainingCalories;
            DashboardUC.summaryGrid.DataContext = Model.Goal;

        }

        public int CalcRemaining()
        {
            return Model.MyBl.CalcRemainingCalories(Model.User, DateTime.Now);
        }

    }
}
