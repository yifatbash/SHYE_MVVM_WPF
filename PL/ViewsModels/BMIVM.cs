using PL.Models;
using PL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewsModels
{
    class BMIVM
    {
        BMIModel model { get; set; }

        BMIUC bMIUC { get; set; }

        float? BMI { get; set; }

        public BMIVM(BMIUC bmiUC)
        {
            model = new BMIModel();
            bMIUC = bmiUC;
            BMI = model.BMI;
            SetBMIView();
        }

        private void SetBMIView()
        {
            bMIUC.BMI_value.Text = BMI.ToString();
            if (BMI < 18.5)
            {
                bMIUC.img_bmi1.Opacity = 1;
                bMIUC.img_bmi2.Opacity = 0.2;
                bMIUC.img_bmi3.Opacity = 0.2;
                bMIUC.img_bmi4.Opacity = 0.2;
                bMIUC.img_bmi5.Opacity = 0.2;
            }
            if (BMI >= 18.5 && BMI <= 24.9)
            {
                bMIUC.img_bmi1.Opacity = 0.2;
                bMIUC.img_bmi2.Opacity = 1;
                bMIUC.img_bmi3.Opacity = 0.2;
                bMIUC.img_bmi4.Opacity = 0.2;
                bMIUC.img_bmi5.Opacity = 0.2;
            }
            if (BMI >= 25 && BMI <= 29.9)
            {
                bMIUC.img_bmi1.Opacity = 0.2;
                bMIUC.img_bmi2.Opacity = 0.2;
                bMIUC.img_bmi3.Opacity = 1;
                bMIUC.img_bmi4.Opacity = 0.2;
                bMIUC.img_bmi5.Opacity = 0.2;
            }
            if (BMI >= 30.0 && BMI <= 34.9)
            {
                bMIUC.img_bmi1.Opacity = 0.2;
                bMIUC.img_bmi2.Opacity = 0.2;
                bMIUC.img_bmi3.Opacity = 0.2;
                bMIUC.img_bmi4.Opacity = 1;
                bMIUC.img_bmi5.Opacity = 0.2;
            }
            if (BMI >= 35)
            {
                bMIUC.img_bmi1.Opacity = 0.2;
                bMIUC.img_bmi2.Opacity = 0.2;
                bMIUC.img_bmi3.Opacity = 0.2;
                bMIUC.img_bmi4.Opacity = 0.2;
                bMIUC.img_bmi5.Opacity = 1;
            }
        }
    }
}
