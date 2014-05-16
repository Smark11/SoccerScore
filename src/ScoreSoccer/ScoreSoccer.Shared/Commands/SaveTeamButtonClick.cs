using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace ScoreSoccer.Commands
{
    public class SaveTeamButtonClick : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            //This is where we save the team.  Guessing we will need a team object
            //sent to us from the Teams screen and then save it
        }
    }
}
