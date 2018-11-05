using FoodShortage.Contracts;
using FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage.Core
{
    public class Engine
    {
        List<IBuyer> buyers;

        public Engine()
        {
            buyers = new List<IBuyer>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);

                if (inputArgs.Length == 4)
                {
                    string id = inputArgs[2];
                    string birthdate = inputArgs[3];

                    IBuyer citizen = new Citizen(name, age, id, birthdate);

                    buyers.Add(citizen);
                }
                else if (inputArgs.Length == 3)
                {
                    string group = inputArgs[2];

                    IBuyer rebel = new Rebel(name, age, group);

                    buyers.Add(rebel);
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                var buyer = buyers.FirstOrDefault(x => x.Name == input);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }

                input = Console.ReadLine();
            }

            Print();
        }

        private void Print()
        {
            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}
