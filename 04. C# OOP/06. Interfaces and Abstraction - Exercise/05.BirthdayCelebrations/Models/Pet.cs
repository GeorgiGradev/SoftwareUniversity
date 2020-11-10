using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BirthdayCelebrations.Models
{
   public class Pet : IDatable
    {
        public Pet(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string BirthDate { get; set; }

    }
}
