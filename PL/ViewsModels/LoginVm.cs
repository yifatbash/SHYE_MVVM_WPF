using PL.Commands;
using PL.Models;
using PL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using SHYE;

namespace PL.ViewsModels
{
    public class LoginVM
    {
        public LoginVM(LoginUC loginUC)
        {
            MyLoginUC = loginUC;
            MyReplaceUCCommand = new ReplaceUCCommand();
            MyReplaceUCCommand.ReplaceUserControl += MyReplaceUCCommand_ReplaceUserControl;
            CurrentModel = new LoginModel();
        }

        #region Class Fields
        public ReplaceUCCommand MyReplaceUCCommand { get; set; }
        public LoginModel CurrentModel { get; set; }
        public LoginUC MyLoginUC { get; set; }
        #endregion

        #region Class Funcs
        private void MyReplaceUCCommand_ReplaceUserControl(string obj)
        {
            switch (obj)
            {
                case "Register":
                    {
                        //((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Remove(MyLoginUC);
                        ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
                        ((MainWindow)System.Windows.Application.Current.MainWindow).menuGrid.IsEnabled = true;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).emailTextBlock.Visibility = Visibility.Visible;
                        ((MainWindow)System.Windows.Application.Current.MainWindow).imageView.Visibility = Visibility.Visible;

                        RegisterUC registerUC = new RegisterUC();
                        registerUC.MaxWidth = 300;
                        registerUC.MaxHeight = 670;

                        ((MainWindow)Application.Current.MainWindow).mainGrid.Children.Add(registerUC);
                        break;
                    }
                case "Login":
                    {
                        //MessageBox.Show("Welcome to SHYE Application!", "Welcome", MessageBoxButton.OK, MessageBoxImage.None);
                        bool found = CurrentModel.findUserByLogin(MyLoginUC.emailTextBox.Text, MyLoginUC.passwPasswordBox.Password);
                        if (found)//model found user by pass and name and set the main user
                        {
                            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
                            ((MainWindow)System.Windows.Application.Current.MainWindow).menuGrid.IsEnabled = true;
                            ((MainWindow)System.Windows.Application.Current.MainWindow).emailTextBlock.Visibility = Visibility.Visible;
                            ((MainWindow)System.Windows.Application.Current.MainWindow).imageView.Visibility = Visibility.Visible;

                            MessageBox.Show("Welcome to SHYE Application!", "Welcome", MessageBoxButton.OK, MessageBoxImage.None);

                            //if should update the details (after a week) go to profile view
                            if ((DateTime.Now.Date - CurrentModel.User.WeightUpdateTime.Date).Days > 7)
                            {
                                MessageBox.Show("Edit your updated weight please!", "Update Weight", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                                //((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();

                                ProfileUC profile = new ProfileUC();
                                ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(profile);
                                return;
                            }
                            else //go to dashboard view
                            {
                                ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(new DashBoardUC());
                                return;
                            }

                            //Remove (MyLoginUC)
                            //((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();

                            //login page-load the profileUC
                            ProfileUC profile_test = new ProfileUC();
                            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(profile_test);

                            profile_test.MaxWidth = 300;
                            profile_test.MaxHeight = 650;
                        }
                        else
                            MessageBox.Show("Your email or password are wrong, sorry!", "Wrong Details", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                default:
                    break;
            }
            #endregion
        }
    }
}
