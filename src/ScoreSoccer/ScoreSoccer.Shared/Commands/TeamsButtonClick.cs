using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ScoreSoccer;



namespace ScoreSoccer.Commands
{
    public class TeamsButtonClick : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {

            Frame frame = Windows.UI.Xaml.Window.Current.Content as Frame;

            frame.Navigate(typeof(Teams));
        }
    }
}
