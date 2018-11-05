using ExplicitInterfaces.Contracts;
using ExplicitInterfaces.Models;
using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();
                string name = inputArgs[0];
                string country = inputArgs[1];
                int age = int.Parse(inputArgs[2]);

                IPerson person = new Citizen(name, country, age);
                Console.WriteLine(person.GetName());

                IResident resident = new Citizen(name, country, age);
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
