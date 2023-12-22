using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
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
        private string pattern = @"([+]+\d{12})";
        public MainWindow()
        {
            InitializeComponent();
            contact = new ObservableCollection<Contact>();
            listBox.ItemsSource = contact;
            listBox.DisplayMemberPath = nameof(Contact.FullInfo);
            this.DataContext = contact;
            phoneTextBox.Text = "+380";
            countryComboBox.Text = "Ukraine +380";
            phoneTextBox.MaxLength = 13;
        }
        private void Clear()
        {
            foreach(var item in stackPanel.Children.OfType<TextBox>())
            {
                item.Text= string.Empty;
            }
            phoneTextBox.Text = "+380";
            countryComboBox.Text = "Ukraine +380";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputText = phoneTextBox.Text;
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(surnameTextBox.Text) || string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(countryComboBox.Text))
            {
                MessageBox.Show("Fill all empty fields!");
            }
            else
            {
                if (Regex.IsMatch(inputText, pattern))
                {
                    contact.Add(new Contact() { Name = nameTextBox.Text, Surname = surnameTextBox.Text, Phone = phoneTextBox.Text, Country = countryComboBox.Text });
                    Clear();
                }
                else
                {
                    MessageBox.Show("Invalid phone number!");
                }
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
            
                Contact select = (listBox.SelectedItem as Contact)!;
                select.Name = nameTextBox.Text;
                select.Surname = surnameTextBox.Text;
                select.Phone = phoneTextBox.Text;
                select.Country = countryComboBox.Text;
        }



        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                nameTextBox.Text = contact[listBox.SelectedIndex].Name;
                surnameTextBox.Text = contact[listBox.SelectedIndex].Surname;
                phoneTextBox.Text = contact[listBox.SelectedIndex].Phone.ToString();
                countryComboBox.Text = contact[listBox.SelectedIndex].Country;
        }


        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text.Length <= 4)
            {
                phoneTextBox.Text = "+380";
            }
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text.Length <= 4)
            {
                phoneTextBox.Text = "+48";
            }
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text.Length <= 4)
            {
                phoneTextBox.Text = "+39";
            }
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text.Length <= 4)
            {
                phoneTextBox.Text = "+33";
            }
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text.Length <=4)
            {
                phoneTextBox.Text = "+43";
            }
        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text.Length <= 4)
            {
                phoneTextBox.Text = "+34";
            }
        }

        private void ComboBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            if (phoneTextBox.Text.Length <= 4)
            {
                phoneTextBox.Text = "+351";
            }
        }
    }
}