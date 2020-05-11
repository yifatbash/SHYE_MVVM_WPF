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
    public class LoginModel
    {
        public User User { get; set; }
        public Bl MyBl { get; set; }

        public LoginModel()
        {
            MyBl = new Bl();
        }
        internal bool findUserByLogin(string email, string password)
        {
            User user = MyBl.findUserByLogin(email, password);
            if (user != null)
            {
                User = user;
                ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.UpdateCurrentUser(User);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
