using BE;
using BL;
using SHYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class DashboardModel
    {
        public User User { get; set; }
        public WeeklyGoal Goal { get; set; }
        public Bl MyBl { get; set; }
        public Dictionary<String, int> ActualFood { get; set; } 
        public List<BMI> BMIs { get; set; }


    public DashboardModel()
        {
            User = ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.CurrentModel.CurrentUser;
            MyBl = new Bl();
            Goal = MyBl.GetCurretWeeklyGoal(User);
            ActualFood = MyBl.GetTotalNutrients(User.Id, DateTime.Now);
            BMIs = MyBl.GetWeight(User.Id);
        }
    }
}
