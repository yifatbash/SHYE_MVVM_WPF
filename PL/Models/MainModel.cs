using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    public class MainModel
    {
        public User CurrentUser { get; set; }
        public MainModel()
        {
            CurrentUser = new User()
            { 
                Email = "email",
                Image_Uri = "../Images/account.png"
            };
        }
    }
}
