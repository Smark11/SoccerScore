using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace ScoreSoccer.Commands
{
    public class AddTeamButtonClick: ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            Frame frame = Windows.UI.Xaml.Window.Current.Content as Frame;

            //TODO When we display screen on an ADD we will want the text boxes to be blank.
            frame.Navigate(typeof(TeamInfo));
        }
    }
}
