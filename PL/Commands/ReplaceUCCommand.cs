using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PL
{
    public class ReplaceUCCommand : ICommand
    {
            public event Action<string> ReplaceUserControl;


            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }

            }


            public bool CanExecute(object parameter)
            {
                if (parameter != null)
                {
                    var good = parameter.ToString();
                    if (good.Length > 0)
                        return true;

                }
                return false;

            }

            public void Execute(object parameter)
            {
                if (ReplaceUserControl != null)
                {
                    ReplaceUserControl(parameter.ToString());
                }
            }
        
    }
}

