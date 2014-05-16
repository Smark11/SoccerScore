using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ScoreSoccer.Classes
{
    public class Game : INotifyPropertyChanged
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

        private string _homeTeam;
        public string HomeTeam
        {
            get { return _homeTeam; }
            set { HomeTeam = value; NotifyPropertyChanged("HomeTeam"); }
        }

        private string _awayTeam;
        public string AwayTeam
        {
            get { return _awayTeam; }
            set { AwayTeam = value; NotifyPropertyChanged("AwayTeam"); }
        }

        private DateTime _gameDate;
        public DateTime GameDate
        {
            get { return _gameDate; }
            set { GameDate = value; NotifyPropertyChanged("GameDate"); }
        }

        private DateTime _gameTime;
        public DateTime GameTime
        {
            get { return _gameTime; }
            set { GameTime = value; NotifyPropertyChanged("GameTime"); }
        }

        private int _playersPerTeam;
        public int PlayersPerTeam
        {
            get { return _playersPerTeam; }
            set { PlayersPerTeam = value; NotifyPropertyChanged("PlayersPerTeam"); }
        }

        private int _periods;
        public int Periods
        {
            get { return _periods; }
            set { Periods = value; NotifyPropertyChanged("Periods"); }
        }

        private int _periodLength;
        public int PeriodLength
        {
            get { return _periodLength; }
            set { PeriodLength = value; NotifyPropertyChanged("PeriodLength"); }
        }

        private string _hasOverTime;
        public string HasOverTime
        {
            get { return _hasOverTime; }
            set { HasOverTime = value; NotifyPropertyChanged("HasOverTime"); }
        }

        private int _overTimeLength;
        public int OverTimeLength
        {
            get { return _overTimeLength; }
            set { OverTimeLength = value; NotifyPropertyChanged("OverTimeLength"); }
        }
#endregion "Properties"
    
    }
}
