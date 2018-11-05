using BorderControl.Contracts;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl.Core
{
    public class Engine
    {
        private ICollection<IIdentifiable> creatures;

        public Engine()
        {
            this.creatures = new List<IIdentifiable>();
        }

        public void Run()
        {
            string[] inputData = Console.ReadLine().Split();

            while (inputData[0] == "End")
            {
                if (inputData.Length == 2)
                {
                    string model = inputData[0];
                    string id = inputData[1];

                    IIdentifiable robot = new Robot(model, id);
                    this.creatures.Add(robot);
                }
                else
                {
                    string name = inputData[0];
                    int age = int.Parse(inputData[1]);
                    string id = inputData[2];

                    IIdentifiable citizen = new Citizen(name, age, id);
                    this.creatures.Add(citizen);
                }

                inputData = Console.ReadLine().Split();
            }

            string lastDigitsOfFakeIds = Console.ReadLine();

            foreach (var item in this.creatures.Where(x => x.Id.EndsWith(lastDigitsOfFakeIds)))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
