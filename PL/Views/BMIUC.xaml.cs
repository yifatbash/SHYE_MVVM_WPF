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

namespace PL.Views
{
    /// <summary>
    /// Logique d'interaction pour BMIUC.xaml
    /// </summary>
    public partial class BMIUC : UserControl
    {
        private BMIVM bMIVM;
        public BMIUC()
        {
            InitializeComponent();
            bMIVM = new BMIVM(this);
            DataContext = bMIVM;
        }

     }
}
