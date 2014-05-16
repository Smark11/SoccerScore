using System;
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
