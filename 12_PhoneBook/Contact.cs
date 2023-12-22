using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_PhoneBook
{
    [AddINotifyPropertyChangedInterface]
    class Contact //: //INotifyPropertyChanged
    {
        //private string name;

        //public string Name
        //{
        //get { return name; }
        //set
        //{
        //name = value;
        //OnPropertyChanged();
        //OnPropertyChanged(nameof(FullName));
        //}
        //}
        //private string surname;

        //public string Surname
        //{
        //    get { return surname; }
        //    set {
        //        surname = value; 
        //        OnPropertyChanged();
        //        OnPropertyChanged(nameof(FullName));
        //    }
        //}
        public string Name { get; set; }
        public string Surname { get; set; } 
        public int Age { get; set; }
        public string Phone  { get; set; }
        public bool IsMale { get; set; }
        public string FullName => $"{Name}  {Surname}";

        public Contact Clone()
        {
            Contact copy = (this.MemberwiseClone() as Contact)!;
            copy.Name = (string)this.Name.Clone();
            copy.Surname = (string)this.Surname.Clone();
            copy.Phone = (string)this.Phone.Clone();
            return copy;
        }
        //public event PropertyChangedEventHandler? PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
