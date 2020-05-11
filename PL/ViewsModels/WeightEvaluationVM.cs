using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Views;
using SHYE;
using BL;
using BE;

namespace PL.ViewsModels
{

    public class WeightEvaluationVM
    {
        public List<WeightModel> Data { get; set; }
        public WeightModel Model { get; set; }
        public WeightGraphUC WeightUC { get; set; }
        public User User { get; set; }
        public Bl MyBL { get; set; }
        public WeightEvaluationVM(WeightGraphUC weightUC)
        {
            Model = new WeightModel();
            WeightUC = weightUC;

            MyBL = new Bl();
            User = ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.CurrentModel.CurrentUser;

            Data = new List<WeightModel>();
            var Weights = MyBL.GetWeight(User.Id);


            foreach(var w in Weights)
            {
                Data.Add(new WeightModel { Date = w.Date.Date, Value = w.Weight });
            }

            //new WeightModel { Date = DateTime.Now.Month.ToString, Value = 60 },
            //new WeightModel { Date = , Value = 70 },
            //new WeightModel { Date = "Steve", Value = 68 },
            //new WeightModel { Date = "Joel", Value = 50 }
        }
    }
}
