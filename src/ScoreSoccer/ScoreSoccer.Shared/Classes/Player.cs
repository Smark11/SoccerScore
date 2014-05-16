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

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { FirstName = value; NotifyPropertyChanged("FirstName"); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { LastName = value; NotifyPropertyChanged("LastName"); }
        }

        private string _uniformNumber;
        public string UniformNumber
        {
            get { return _uniformNumber; }
            set { UniformNumber = value; NotifyPropertyChanged("UniformNumber"); }
        }

        private string _height;
        public string Height
        {
            get { return _height; }
            set { Height = value; NotifyPropertyChanged("Height"); }
        }

        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set { Weight = value; NotifyPropertyChanged("Weight"); }
        }

        private string _kicks;
        public string Kicks
        {
            get { return _kicks; }
            set { Kicks = value; NotifyPropertyChanged("Kicks"); }
        }

        private string _starter;
        public string Starter
        {
            get { return _starter; }
            set { Starter = value; NotifyPropertyChanged("Starter"); }
        }

        #endregion "Properties"

    }
}
