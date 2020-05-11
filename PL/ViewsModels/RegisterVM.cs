using BE;
using PL.Commands;
using PL.Models;
using PL.Views;
using SHYE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PL.ViewsModels
{
    public class RegisterVM : INotifyPropertyChanged
    {
        private RegisterUC registerUC;
        private LoginUC loginUC;
        public ReplaceUCCommand MyReplaceUCCommand { get; set; }
        public DateCommand MyDateCommand { get; set; }
        public OpenFileCommand MyOpenFileCommand { get; set; }
        public GenderCommand MyGenderCommand { get; set; }
        public RegisterVM(RegisterUC regUC)
        {
            CurrentModel = new RegisterModel();
            this.registerUC = regUC;
            this.loginUC = new LoginUC();
            MyDateCommand = new DateCommand();
            MyDateCommand.showCalendar += MyDateCommand_showCalendar;

            MyOpenFileCommand = new OpenFileCommand();
            MyOpenFileCommand.openFile += MyOpenFileCommand_openFile;

            MyReplaceUCCommand = new ReplaceUCCommand();
            MyReplaceUCCommand.ReplaceUserControl += MyReplaceUCCommand_ReplaceUserControl;
        }

        #region Class Fields
        public RegisterModel CurrentModel { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public string FirstName
        {
            get { return CurrentModel.CurrentUser.FirstName; }
            set
            {
                CurrentModel.CurrentUser.FirstName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        public string LastName
        {
            get { return CurrentModel.CurrentUser.LastName; }
            set
            {
                CurrentModel.CurrentUser.LastName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }
        public DateTime Birthday
        {
            get { return CurrentModel.CurrentUser.Birthday; }
            set
            {
                CurrentModel.CurrentUser.Birthday = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Birthday"));
            }
        }
        public Gender Gender
        {
            get { return CurrentModel.CurrentUser.Gender; }
            set
            {
                CurrentModel.CurrentUser.Gender = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
            }
        }
        public string Email
        {
            private get { return CurrentModel.CurrentUser.Email; }
            set
            {
                CurrentModel.CurrentUser.Email = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string Password
        {
            private get { return CurrentModel.CurrentUser.Password; }
            set
            {
                CurrentModel.CurrentUser.Password = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public string Address
        {
            private get { return CurrentModel.CurrentUser.Address; }
            set
            {
                CurrentModel.CurrentUser.Address = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Address"));
            }
        }
        public string PhoneNumber
        {
            private get { return CurrentModel.CurrentUser.PhoneNumber; }
            set
            {
                CurrentModel.CurrentUser.PhoneNumber = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PhoneNumber"));
            }
        }
        public string Image_Uri
        {
            get { return CurrentModel.CurrentUser.Image_Uri; }
            set
            {
                CurrentModel.CurrentUser.Image_Uri = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Image_Uri"));
            }
        }
        public float? Height
        {
            get { return CurrentModel.CurrentUser.Height; }
            set
            {
                CurrentModel.CurrentUser.Height = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Height"));
            }
        }
        public float? Weight
        {
            get { return CurrentModel.CurrentUser.Weight; }
            set
            {
                CurrentModel.CurrentUser.Weight = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Weight"));
            }
        }

        public float? Goal
        {
            private get { return CurrentModel.Goal.WantedCalories; }
            set
            {
                CurrentModel.Goal.WantedCalories = (float)value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Goal"));
            }
        }
        public DateTime WeightUpdateTime
        {
            get { return CurrentModel.CurrentUser.WeightUpdateTime; }
            set
            {
                CurrentModel.CurrentUser.WeightUpdateTime = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WeightUpdateTime"));

            }
        }
        #endregion

        #region Class Funcs
        //to check if we need that 
        private void MyDateCommand_showCalendar()
        {
            DateUC dateUC = new DateUC(this);

            Grid.SetColumn(dateUC, 2);
            Grid.SetColumnSpan(dateUC, 2);
            Grid.SetRow(dateUC, 0);
            Grid.SetRowSpan(dateUC, 2);

            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(dateUC);
        }

        private void MyOpenFileCommand_openFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image_Uri = open.FileName;
            }
        }
        private void MyReplaceUCCommand_ReplaceUserControl(string obj)
        {
            switch (obj)
            {
                case "Ok":
                    {

                        while (checkFields() == false)
                            return;
                        if (CurrentModel.CheckExistUser())
                        {
                            System.Windows.MessageBox.Show("This email already exists, please choose another.", "Exit Email", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        CurrentModel.addNewUser();
                        System.Windows.MessageBox.Show("You are added sucessfully!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                        ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.UpdateCurrentUser(CurrentModel.CurrentUser);
                        ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Remove(registerUC);
                        ((MainWindow)System.Windows.Application.Current.MainWindow).menuGrid.IsEnabled = true;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(new DashBoardUC());
                        break;
                    }

                case "Login":
                    {
                        ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
                        ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(loginUC);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }



        }
        #endregion
        bool checkFields()
        {
            if (registerUC.genderMale.IsChecked == true && registerUC.genderFemale.IsChecked == true)
            {
                System.Windows.MessageBox.Show("You are a men or women? Choose again your gender, please", "Choose Gender", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else
            {
                if (registerUC.genderMale.IsChecked == true)
                    Gender = Gender.Male;
                else
                {
                    if (registerUC.genderFemale.IsChecked == true)
                        Gender = Gender.Female;
                    else
                    {
                        System.Windows.MessageBox.Show("Select your gender, please!", "Choose Gender", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        return false;
                    }
                }
            }
            if (registerUC.FirstNameTextBox.Text.ToString() == "")
            {
                System.Windows.MessageBox.Show("Enter your first name, please!", "First Name", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            if (registerUC.LastNameTextBox.Text.ToString() == "")
            {
                System.Windows.MessageBox.Show("Enter your last name, please!", "Last Name", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            if (registerUC.PhoneTextBox.Text.ToString() == "")
            {
                System.Windows.MessageBox.Show("Enter your first name, please!", "Phone Number", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else
            {
                var regex = new Regex(@"^05\d([-]{0,1})\d{7}$");
                Match match = regex.Match(registerUC.PhoneTextBox.Text.ToString());
                if (!match.Success)
                {
                    System.Windows.MessageBox.Show("Your phone number is not valid. Enter again your phone, please!", "Phone number", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return false;
                }
            }
            if (registerUC.EmailTextBox.Text.ToString() == "")
            {
                System.Windows.MessageBox.Show("Enter your email, please!", "Email", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(registerUC.EmailTextBox.Text.ToString());
                if (!match.Success)
                {
                    System.Windows.MessageBox.Show("Your email is not valid. Enter again yout email address, please!", "Email", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return false;
                }
            }
            if (registerUC.PasswordBox.Password.ToString() == "")
            {
                System.Windows.MessageBox.Show("Enter your password, please!", "Password", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else
            {
                if (registerUC.PasswordBox.Password.ToString().Length < 8)
                {
                    System.Windows.MessageBox.Show("Your password must contain at least 8 characters", "Password", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return false;
                }
            }
            if (registerUC.HeightTextBox.Text.ToString() == "")
            {
                System.Windows.MessageBox.Show("Enter your height, please!", "Height", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            if (registerUC.WeightTextBox.Text.ToString() == "")
            {
                System.Windows.MessageBox.Show("Enter your weight, please!", "Weight", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            return true;
        }
    }
}
