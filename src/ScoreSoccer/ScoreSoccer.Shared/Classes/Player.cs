using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ScoreSoccer.Classes
{
    public class Player: INotifyPropertyChanged
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

        private string _playerName;
        public string PlayerName
        {
            get { return _playerName; }
            set { PlayerName = value; NotifyPropertyChanged("PlayerName"); }
        }


        #endregion "Properties"

    }
}
