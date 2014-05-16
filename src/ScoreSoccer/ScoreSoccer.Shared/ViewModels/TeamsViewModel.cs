using ScoreSoccer.Classes;
using ScoreSoccer.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace ScoreSoccer.ViewModels
{
    public class TeamsViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public TeamsViewModel()
        {
            AddTeamButton = new AddTeamButtonClick();
            EditTeamButton = new EditTeamButtonClick();

            TeamsList = new ObservableCollection<Team>();

            //Test code will be replaced by a GETTEAMS proc
            //Just trying to get some teams to show up in listbox so we can
            //edit and add teams
            //START TEST CODE
            Team _team1 = new Team();        
            _team1.TeamName = "Farmington";
            _team1.Coach = "Chris";
            TeamsList.Add(_team1);

            Team _team2 = new Team();
            _team2.TeamName = "Avon";
            _team2.Coach = "Steve";
            TeamsList.Add(_team2);
            //END TEST CODE

        }

        public ICommand AddTeamButton
        {
            get;
            private set;
        }

        public ICommand EditTeamButton
        {
            get;
            private set;
        }

        public ICommand StatsButton
        {
            get;
            private set;
        }

        #region "Properties"

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ObservableCollection<Team> _teamsList;
        public ObservableCollection<Team> TeamsList
        {
            get { return _teamsList; }
            set { TeamsList = value; NotifyPropertyChanged("TeamsList"); }
        }

        #endregion "Properties"


    }
}
