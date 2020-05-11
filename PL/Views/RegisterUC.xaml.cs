using PL.ViewsModels;
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
    /// Logic interaction for RegisterUC.xaml
    /// </summary>
    public partial class RegisterUC : UserControl
    {
        public RegisterVM registerVM { get; set; }
        public RegisterUC()
        {
            InitializeComponent();
            registerVM = new RegisterVM(this);
            this.DataContext = registerVM;
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { 
                 ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; 
            }
        }
    }
}

