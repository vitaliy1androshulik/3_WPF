using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace _12_PhoneBook
{
    [AddINotifyPropertyChangedInterface]
    class ViewModel
    {
        //private ObservableCollection<Contact> contacts;
        private ObservableCollection<PhoneBook> phoneBooks = null;
        private RelayCommand dublicateCommand;
        private RelayCommand removeCommand;
        private RelayCommand clearCommand;
        private RelayCommand addPhoneBookCommand;

        private PhoneBook phoneBook;
        public PhoneBook SelectedPhoneBook
        {
            get { return phoneBook; }
            set { phoneBook = value ?? new PhoneBook(); }
        }

        public ViewModel()
        {
            phoneBooks = new ObservableCollection<PhoneBook>();
            //contacts.Add(new Contact() { Name = "Vova", Age = 30, Surname = "Pupkin", Phone = "+3807575828", IsMale = true });
            //contacts.Add(new Contact() { Name = "Marusia", Age = 25, Surname = "Shishik", Phone = "+380771244", IsMale = false });
            //contacts.Add(new Contact() { Name = "Olga", Age = 33, Surname = "Shelesh", Phone = "+38067285792", IsMale = false });
            dublicateCommand = new RelayCommand((o) => DublicateSelectedContact(),(o)=> SelectedPhoneBook != null);
            removeCommand = new RelayCommand((o) => DeleteSelectedContact(), (o) => SelectedPhoneBook != null);
            clearCommand = new RelayCommand((o) => phoneBooks.Clear(), (o)=> phoneBooks.Any());
            addPhoneBookCommand = new RelayCommand((o) => AddNewContact());
            SelectedPhoneBook = new PhoneBook();
        }

        //public IEnumerable<Contact> Contacts => contacts; //прив'язуємося до contacs
        public IEnumerable<PhoneBook> PhoneBooks => phoneBooks;
        public ICommand DublicateCommandCmd => dublicateCommand;
        public ICommand RemoveCommandCmd => removeCommand;
        public ICommand ClearCommandCmd => clearCommand;
        public ICommand AddCommandCmd => addPhoneBookCommand;
        //public Contact SelectedContact { get; set; }
        public void DeleteSelectedContact()
        {
            if(SelectedPhoneBook != null)
            {
                phoneBooks.Remove(SelectedPhoneBook);
            }
        }
        public void DeleteAllContact()
        {
            if (phoneBooks.Any())
            {
                phoneBooks.Clear();
            }
        }
        public void DublicateSelectedContact()
        {
            if (SelectedPhoneBook != null)
            {
                phoneBooks.Add(SelectedPhoneBook.Clone());
            }
        }
        public void AddNewContact()
        {
            phoneBooks.Add(SelectedPhoneBook.Clone()); // TODO: deep copy
        }
    }
}