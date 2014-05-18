using ScoreSoccer.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace ScoreSoccer.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand TeamsButton
        {
            get;
            private set;
        }

        public MainPageViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string t)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(t));
            }
        }

        #region commands

        #region Team Screen Command
        /// <summary>
        /// To Set up a new Command, 3 steps.
        /// 1.  Create Private variable of type ICommand.
        /// </summary>
        private ICommand _teamScreenCommand;
        //Step 2.  Create public command.  This is the property that the UI will bind to.  You have to pass in the method that
        //Will be executed when the command is fired, along with whether or not it can be executed or not.  (For Instance, sometimes you may
        //want to allow the user to edit)
        public ICommand TeamScreenCommand
        {
            get
            {
                if (_teamScreenCommand == null)
                {
                    _teamScreenCommand = new DelegateCommand(param => this.GoToTeamScreen(), param => true);
                }

                return _teamScreenCommand;
            }
        }

        /// <summary>
        /// This is the method that fires when the command is fired.  You'll need a new one of these for each command.
        /// </summary>
        private void GoToTeamScreen()
        {
#if WINDOWS_PHONE_APP


            Frame frame = Windows.UI.Xaml.Window.Current.Content as Frame;
            frame.Navigate(typeof(Teams));

#endif
        }
        #endregion Team Screen Command

        #endregion commands

    }
}
