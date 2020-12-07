using System;
using System.ComponentModel;

namespace Laboratorium3
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private string _name;
        private string _city;
        private string _date;

        public string Name
        {
            get => _name;
            set { _name = value; OnPropChanged("Name"); }
        }

        public string City
        {
            get => _city;
            set { _city = value; OnPropChanged("City"); }
        }

        public string DateTime
        {
            get => _date;
            set { _date = value; OnPropChanged("Date"); }
        }

        public Person(string name, string city, string dateTime)
        {
            _name = name;
            _city = city;
            _date = dateTime;
        }
    }
}