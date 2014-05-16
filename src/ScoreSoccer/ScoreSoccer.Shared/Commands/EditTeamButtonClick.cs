using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace ScoreSoccer.Commands
{
    public class EditTeamButtonClick : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            Frame frame = Windows.UI.Xaml.Window.Current.Content as Frame;

            //TODO When we display screen on an EDIT we will want to pass in the values to the screen.
            frame.Navigate(typeof(TeamInfo));
        }
    }
}
