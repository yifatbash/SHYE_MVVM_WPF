using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class RegisterModel
    {
        public User CurrentUser { get; set; }

        public WeeklyGoal Goal { get; set; }
        public Bl MyBl { get; set; }

        public RegisterModel()
        {
            CurrentUser = new User()
            {
                Image_Uri = "../Images/account.png",
                Birthday = DateTime.Now,
                WeightUpdateTime = DateTime.Now
            };
            Goal = new WeeklyGoal()
            {
                User = CurrentUser,
                Date= DateTime.Now
            };
            MyBl = new Bl();
        }
        internal bool CheckExistUser()
        {
            return MyBl.CheckExistUser(CurrentUser.Email);
        }
        internal void addNewUser()
        {
            
            MyBl.addNewUser(CurrentUser,Goal);
        }
    }
}
