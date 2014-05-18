using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace ScoreSoccer.Classes
{
    public class Team: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
     
        #region "Properties"

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _teamName;
        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; NotifyPropertyChanged("TeamName"); }
        }

        private string _teamShortName;
        public string TeamShortName
        {
            get { return _teamShortName; }
            set { _teamShortName = value; NotifyPropertyChanged("TeamShortName"); }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; NotifyPropertyChanged("Color"); }
        }

        private string _coach;
        public string Coach
        {
            get { return _coach; }
            set { _coach = value; NotifyPropertyChanged("Coach"); }
        }
#endregion "Properties"

        #region Team Screen Command

        private ICommand _goToTeamInfoCommand;
        public ICommand GoToTeamInfoCommand
        {
            get
            {
                if (_goToTeamInfoCommand == null)
                {
                    _goToTeamInfoCommand = new DelegateCommand(param => this.GoToTeamInfoScreen(), param => true);
                }

                return _goToTeamInfoCommand;
            }
        }

        private void GoToTeamInfoScreen()
        {
#if WINDOWS_PHONE_APP

            //Step 1, set static team variable
            TeamInfoStaticParams.SelectedTeam = this;

            Frame frame = Windows.UI.Xaml.Window.Current.Content as Frame;
            frame.Navigate(typeof(TeamInfo),this);

#endif
        }
        #endregion Team Screen Command
      
    }
}
