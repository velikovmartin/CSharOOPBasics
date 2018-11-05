using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        private ICollection<IIdentifiable> creatures;
        private ICollection<IBirthable> birthdays;

        public Engine()
        {
            this.creatures = new List<IIdentifiable>();
            this.birthdays = new List<IBirthable>();
        }

        public void Run()
        {
            string[] inputData = Console.ReadLine().Split();

            while (inputData[0] != "End")
            {
                string type = inputData[0];
                if (type == "Robot")
                {
                    string model = inputData[1];
                    string id = inputData[2];

                    IIdentifiable robot = new Robot(model, id);
                    this.creatures.Add(robot);
                }
                else if (type == "Citizen")
                {
                    string name = inputData[1];
                    int age = int.Parse(inputData[2]);
                    string id = inputData[3];
                    string birthday = inputData[4];

                    //IIdentifiable citizen = new Citizen(name, age, id, birthday);
                    IBirthable citizen = new Citizen(name, age, id, birthday);
                    //this.creatures.Add(citizen);
                    this.birthdays.Add(citizen);
                }
                else
                {
                    string name = inputData[1];
                    string birthday = inputData[2];

                    IBirthable pet = new Pet(name, birthday);
                    this.birthdays.Add(pet);
                }
                inputData = Console.ReadLine().Split();
            }

            string year = Console.ReadLine();

            foreach (var item in this.birthdays.Where(x => x.Birthdate.EndsWith(year)))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
