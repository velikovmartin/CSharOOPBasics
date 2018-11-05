using ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Models
{
    public class Citizen : IResident, IPerson
    {
        private string name;
        private string country;
        private int age;

        public Citizen(string name, string coutry, int age)
        {
            this.Name = name;
            this.Country = coutry;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public int Age { get => age; set => age = value; }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
