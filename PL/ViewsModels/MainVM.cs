using BE;
using PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewsModels
{
    public class MainVM: INotifyPropertyChanged
    {
        public MainVM()
        {
            CurrentModel = new MainModel();
        }

        #region Class Fields
        public MainModel CurrentModel { get; set; }
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
        public string Email
        {
            get { return CurrentModel.CurrentUser.Email; }
            set
            {
                CurrentModel.CurrentUser.Email = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
       
        #endregion

        #region Class Funcs
        public void UpdateCurrentUser(User user)
        {
            CurrentModel.CurrentUser = user;
            Image_Uri = user.Image_Uri;
            Email = user.Email;
        }
        #endregion
    }
}
