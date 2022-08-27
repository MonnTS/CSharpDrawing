using System.ComponentModel;

namespace Laboratorium3
{
    public class Person : INotifyPropertyChanged
    {
        private string _city;
        private string _date;
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropChanged(nameof(Name));
            }
        }

        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropChanged(nameof(City));
            }
        }

        public string DateTime
        {
            get => _date;
            set
            {
                _date = value;
                OnPropChanged(nameof(DateTime));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        
        public Person(string name, string city, string dateTime)
        {
            Name = name;
            City = city;
            DateTime = dateTime;
        }

        public Person()
        {
        }
        
        ~Person()
        {
        }
    }
}