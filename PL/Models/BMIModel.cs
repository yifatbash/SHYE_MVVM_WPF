using BE;
using SHYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Models
{
    class BMIModel
    {
        public BL.Bl MyBl { get; set; }
        public User MyUser { get; set; }
        public float? BMI { get; set; }

        public BMIModel()
        {
            MyUser = ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.CurrentModel.CurrentUser;
            MyBl = new BL.Bl();
            BMI = MyBl.calculateBMI(MyUser);
        }
    }
}
