﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ScoreSoccer.Classes
{
    public class Stat : INotifyPropertyChanged
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

        private string _playerLastName;
        public string PlayerLastName
        {
            get { return _playerLastName; }
            set { PlayerLastName = value; NotifyPropertyChanged("PlayerLastName"); }
        }

        private string _playerFirstName;
        public string PlayerFirstName
        {
            get { return _playerFirstName; }
            set { PlayerFirstName = value; NotifyPropertyChanged("PlayerFirstName"); }
        }

        private string _uniformNumber;
        public string UniformNumber
        {
            get { return _uniformNumber; }
            set { UniformNumber = value; NotifyPropertyChanged("UniformNumber"); }
        }

        private string _statName;
        public string StatName
        {
            get { return _statName; }
            set { StatName = value; NotifyPropertyChanged("StatName"); }
        }

        private int _statValue;
        public int StatValue
        {
            get { return _statValue; }
            set { StatValue = value; NotifyPropertyChanged("StatValue"); }
        }
        #endregion "Properties"
    }
}
