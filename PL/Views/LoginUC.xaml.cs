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
    /// Logic interaction for LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        public LoginVM MyLoginVM { get; set; }
        public LoginUC()
        {
            InitializeComponent();
            MyLoginVM = new LoginVM(this);
            this.DataContext = MyLoginVM;

            if ((Properties.Settings.Default.email) != string.Empty)
            {
                emailTextBox.Text = (Properties.Settings.Default.email).ToString();
                passwPasswordBox.Password = (Properties.Settings.Default.password).ToString();
            }
        }
        
    }
}
