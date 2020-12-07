using System.Collections.ObjectModel;
using System.Windows;

namespace Laboratorium5
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> PersonsList { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            
            PersonsList = new ObservableCollection<Person>();
            var person = new Person("Barak", "Honolulu", "1961.08.04");
            PersonsList.Add(person);
            person = new Person("Donald", "New York", "1946.06.14");
            PersonsList.Add(person);
            person = new Person("Joe", "Scranton", "1942.11.20");
            PersonsList.Add(person);
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newPerson = new Person(txtname.Text, txtcity.Text, txtdate.Text);
            PersonsList.Add(newPerson);
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MyListView.SelectedItem != null)
            {
                PersonsList.Remove((Person)MyListView.SelectedItem);
            }
        }
    }
}
