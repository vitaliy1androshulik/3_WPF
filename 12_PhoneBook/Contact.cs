﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_PhoneBook
{
    class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone  { get; set; }
        public bool IsMale { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
