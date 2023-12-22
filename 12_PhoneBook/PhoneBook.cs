using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _12_PhoneBook
{
    [AddINotifyPropertyChangedInterface]
    internal class PhoneBook
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public PhoneBook Clone()
        {
            
            PhoneBook copyPhoneBook = (this.MemberwiseClone() as PhoneBook)!;
            copyPhoneBook.Name = (string)this.Name.Clone();
            copyPhoneBook.Surname = (string)this.Surname.Clone();
            copyPhoneBook.Phone = (string)this.Phone.Clone();
            return copyPhoneBook;
        }
        public string FullInfo => Name + ", " + Surname + ", " + Phone;
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
