using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace _9_ListBoxHomeWorkk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Contact> contact;
        public MainWindow()
        {
            InitializeComponent();
            contact = new ObservableCollection<Contact>();
            listBox.ItemsSource = contact;
            listBox.DisplayMemberPath = nameof(Contact.FullInfo);
            this.DataContext = contact;
        }
        private void Clear()
        {
            foreach(var item in stackPanel.Children.OfType<TextBox>())
            {
                item.Text= string.Empty;
            }
            countryComboBox.Text = string.Empty;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(surnameTextBox.Text) || string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(countryComboBox.Text))
            {
                MessageBox.Show("Fill all empty fields!");
            }
            else
            {
                contact.Add(new Contact() { Name = nameTextBox.Text, Surname = surnameTextBox.Text, Phone = int.Parse(phoneTextBox.Text), Country = countryComboBox.Text });
                Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(listBox.SelectedItem!=null)
            {
                contact.RemoveAt(listBox.SelectedIndex);
            }
        }


        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (listBox.SelectedItem != null) 
            {
                Contact select = (listBox.SelectedItem as Contact)!;
                select.Name = nameTextBox.Text;
                select.Surname = surnameTextBox.Text;
                select.Phone = int.Parse(phoneTextBox.Text);
                select.Country = countryComboBox.Text;
            }
            Clear();
        }



        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                nameTextBox.Text = contact[listBox.SelectedIndex].Name;
                surnameTextBox.Text = contact[listBox.SelectedIndex].Surname;
                phoneTextBox.Text = contact[listBox.SelectedIndex].Phone.ToString();
                countryComboBox.Text = contact[listBox.SelectedIndex].Country;
            }
        }
    }
}