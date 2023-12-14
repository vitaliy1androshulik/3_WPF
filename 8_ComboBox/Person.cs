﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ComboBox
{
    class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public string Fullname => Name + " " + Surname;

        public override string ToString()
        {
            return $"Name : {Name}, Surname : {Surname}, Birthday : {Birthday}";
        }
    }
}
