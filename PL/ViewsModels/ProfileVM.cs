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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.ViewsModels
{
    public class ProfileVM : INotifyPropertyChanged
    {
        public ProfileVM(ProfileUC profileUc)
        {
            Current_Model = new ProfileModel();
            replaceCommand = new ReplaceUCCommand();
            replaceCommand.ReplaceUserControl += ReplaceCommand_ReplaceUserControl;
            MyProfileUC = profileUc;
            MyOpenFileCommand = new OpenFileCommand();
            MyOpenFileCommand.openFile += MyOpenFileCommand_openFile;
        }

        #region Class Fields

        public ReplaceUCCommand replaceCommand { get; set; }
        public ProfileModel Current_Model { get; set; }
        public ProfileUC MyProfileUC { get; set; }
        public OpenFileCommand MyOpenFileCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public string Email
        {
            get { return Current_Model.Current_User.Email; }
            set
            {
                Current_Model.Current_User.Email = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string FirstName
        {
            get { return Current_Model.Current_User.FirstName; }
            set
            {
                Current_Model.Current_User.FirstName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        public string LastName
        {
            get { return Current_Model.Current_User.LastName; }
            set
            {
                Current_Model.Current_User.LastName = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }
        public string Address
        {
            get { return Current_Model.Current_User.Address; }
            set
            {
                Current_Model.Current_User.Address = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Address"));
            }
        }
        public string PhoneNumber
        {
            get { return Current_Model.Current_User.PhoneNumber; }
            set
            {
                Current_Model.Current_User.PhoneNumber = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PhoneNumber"));
            }
        }
        public float? Height
        {
            get { return Current_Model.Current_User.Height; }
            set
            {
                Current_Model.Current_User.Height = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Height"));
            }
        }
        public float? Weight
        {
            get { return Current_Model.Current_User.Weight; }
            set
            {
                Current_Model.Current_User.Weight = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Weight"));
            }
        }
        public DateTime WeightUpdateTime
        {
            get { return Current_Model.Current_User.WeightUpdateTime; }
            set
            {
                Current_Model.Current_User.WeightUpdateTime = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WeightUpdateTime"));

            }
        }

        public float? Goal
        {
            private get { return Current_Model.Goal.WantedCalories; }
            set
            {
                Current_Model.Goal.WantedCalories = (float)value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Goal"));
            }
        }

        public string Image_Uri
        {
            get { return Current_Model.Current_User.Image_Uri; }
            set
            {
                Current_Model.Current_User.Image_Uri = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Image_Uri"));
            }
        }



        #endregion

        #region Class Funcs

        private void MyOpenFileCommand_openFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image_Uri = open.FileName;
            }
        }
        private void ReplaceCommand_ReplaceUserControl(string obj)
        {

            Current_Model.Current_User.WeightUpdateTime = DateTime.Now;
            Current_Model.MyBl.SaveWeeklyGoal(Current_Model.Goal);
            Current_Model.updateUser();
            ((MainWindow)System.Windows.Application.Current.MainWindow).MainVM.UpdateCurrentUser(Current_Model.Current_User);
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
            ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(new DashBoardUC());

            /* OptionsUC optionsUC = new OptionsUC();
            Grid.SetColumn(optionsUC, 0);
            Grid.SetRow(optionsUC, 0);
            Grid.SetRowSpan(optionsUC, 2);
            Grid.SetColumnSpan(optionsUC, 2);*/

            //((MainWindow)System.Windows.Application.Current.MainWindow).innerGrid.Children.Add(optionsUC);
        }

        //private float? GetWeeklyGoal(User user)
        //{
        //    return Current_Model.MyBl.GetCurretWeeklyGoal(user).WantedCalories;
        //}

        #endregion
    }
}
