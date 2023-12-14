using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _9_ListBoxHomeWorkk
{
    public class Contact : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        private int phone;

        public int Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged(nameof(FullInfo));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string FullInfo => Name + " " + Surname + " : " + Phone;
        public override string ToString()
        {
            return Name + " "+Surname + " : "+Phone;
        }
    }
}
