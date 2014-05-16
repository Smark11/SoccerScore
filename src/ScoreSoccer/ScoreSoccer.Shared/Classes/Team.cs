using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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
            set { TeamName = value; NotifyPropertyChanged("TeamName"); }
        }

        private string _teamShortName;
        public string TeamShortName
        {
            get { return _teamShortName; }
            set { TeamShortName = value; NotifyPropertyChanged("TeamShortName"); }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { Color = value; NotifyPropertyChanged("Color"); }
        }

        private string _coach;
        public string Coach
        {
            get { return _coach; }
            set { Coach = value; NotifyPropertyChanged("Coach"); }
        }
#endregion "Properties"
      
    }
}
