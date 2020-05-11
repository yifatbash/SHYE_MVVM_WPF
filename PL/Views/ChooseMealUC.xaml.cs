﻿using PL.ViewsModels;
using System;
using System.Collections.Generic;
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

namespace SHYE
{
    /// <summary>
    /// Interaction logic for ChooseMealUC.xaml
    /// </summary>
    public partial class ChooseMealUC : UserControl
    {
        public ChooseMealVM ChooseMeal { get; set; }
        public ChooseMealUC()
        {
            InitializeComponent();
            ChooseMeal = new ChooseMealVM(this);

            this.DataContext = ChooseMeal;
        }
    }
}
