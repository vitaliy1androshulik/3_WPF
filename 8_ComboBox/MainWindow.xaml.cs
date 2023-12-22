using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _8_ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> persons; // list
        public MainWindow()
        {
            InitializeComponent();
            persons = new ObservableCollection<Person>()
            {
                new Person(){Name = "Olga", Surname="Ivanchuk", Birthday=new DateTime(2000,5,17)},
                new Person(){Name = "Bob", Surname="Thompson", Birthday=new DateTime(2005,6,27)},
                new Person(){Name = "Tom", Surname="Petrovich", Birthday=new DateTime(2004,3,5)}
            };
            comboBox.Items.Clear();
            comboBox.SelectedIndex = 0;
            //foreach(Person person in persons) 
            //{
            //    comboBox.Items.Add(person);
            //}

            comboBox.ItemsSource= persons;
            comboBox.DisplayMemberPath = nameof(Person.Fullname);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var person = new Person() { Name = "Mukola", Surname = "Mukolavich", Birthday = new DateTime(2011, 2, 1) };
            persons.Add(person);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex != -1)
            {
                persons.RemoveAt(comboBox.SelectedIndex);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            persons.Clear();

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBox.SelectedItem!=null)
            {
                MessageBox.Show(comboBox.SelectedItem.ToString());
            }
        }
    }
}