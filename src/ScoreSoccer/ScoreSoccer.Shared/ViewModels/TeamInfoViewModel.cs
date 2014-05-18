using ScoreSoccer.Classes;
using ScoreSoccer.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml.Navigation;

namespace ScoreSoccer.ViewModels
{
    public class TeamInfoViewModel : INotifyPropertyChanged
    {
        public TeamInfoViewModel()
        {
            SaveTeamButton = new SaveTeamButtonClick();
         //   TeamInfo = new Team();
       //     TeamInfo.TeamName = "Farmington";

            TeamInfo = new Team();
            TeamInfo.TeamName = TeamInfoStaticParams.SelectedTeam.TeamName;
            TeamInfo.Coach = TeamInfoStaticParams.SelectedTeam.Coach;

        }


        public event PropertyChangedEventHandler PropertyChanged;

        #region "Properties"

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Team _teamInfo;
        public Team TeamInfo
        {
            get { return _teamInfo; }
            set { _teamInfo = value; NotifyPropertyChanged("TeamInfo"); }
        }

        #endregion "Properties"

        public ICommand SaveTeamButton
        {
            get;
            private set;
        }    

    }
}
