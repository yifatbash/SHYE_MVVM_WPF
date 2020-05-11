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
    /// Logic interaction for ProfileUC.xaml
    /// </summary>
    public partial class ProfileUC : UserControl
    {
        public ProfileVM MyProfileVM { get; set; }
        public ProfileUC()
        {
            InitializeComponent();
            MyProfileVM = new ProfileVM(this);
            this.DataContext = MyProfileVM;
            //this.image_imageBrush..ToString() = MyProfileVM.Image_Uri; 
           // this.address_txtBox.Text = MyProfileVM.Address;
            this.firstName_txtBox.Text = MyProfileVM.FirstName;
            this.lastName_txtBox.Text = MyProfileVM.LastName;
            this.phone_txtBox.Text = MyProfileVM.PhoneNumber; 
            this.height_txtBox.Text = MyProfileVM.Height.ToString();
            this.weight_txtBox.Text = MyProfileVM.Weight.ToString();
        }
    }
}

