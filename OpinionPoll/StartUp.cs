using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                People.AddMember(person);
            }

            List<Person> overThirty = People.GetPeopleAgedOverThirty();

            foreach (var person in overThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
