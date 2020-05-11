using BE;
using BL;
using PL.Views;
using SHYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class ProfileModel
    {
        public Bl MyBl { get; set; }
        public User Current_User { get; set; }
        public WeeklyGoal Goal { get; set; }
        public ProfileModel()
        {
            MyBl = new Bl();
            Current_User = ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.CurrentModel.CurrentUser;
            Goal = MyBl.GetCurretWeeklyGoal(Current_User);
        }
        internal void updateUser()
        {
            MyBl.updateUser(Current_User);
        }
    }
}
