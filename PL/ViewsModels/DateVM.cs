using PL.Commands;
using PL.Views;
using SHYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PL.ViewsModels
{
    public class DateVM
    {
        public DateVM(DateUC dateUC, RegisterVM regVM)
        {
            this.dateUC = dateUC;
            registerVM = regVM;
            calendarCommand = new CalendarCommand();
            calendarCommand.removeCalendar += CalendarCommand_removeCalendar;
        }

        #region Class Fields
        public DateUC dateUC { get; set; }
        public RegisterVM registerVM { get; set; }
        public CalendarCommand calendarCommand { get; set; }
        #endregion

        #region Class Funcs
        private void CalendarCommand_removeCalendar()
        {
            if (dateUC.date.SelectedDate != null)
            {
                registerVM.Birthday = (DateTime)dateUC.date.SelectedDate;
            }

        ((MainWindow)Application.Current.MainWindow).mainGrid.Children.Remove(dateUC);
        }
        #endregion
    }
}
