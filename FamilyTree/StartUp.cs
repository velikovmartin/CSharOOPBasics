﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    public class StartUp
    {
        static List<Person> people;
        static List<string> relations;

        static void Main(string[] args)
        {
            people = new List<Person>();
            relations = new List<string>();

            string mainPerson = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!input.Contains('-'))
                {
                    Addmember(input);
                    input = Console.ReadLine();
                    continue;
                }

                relations.Add(input);

                input = Console.ReadLine();
            }

            foreach (var membersInfo in relations)
            {
                string[] inputArgs = membersInfo.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                Person parent = GetPerson(inputArgs[0]);
                Person child = GetPerson(inputArgs[1]);

                if (!parent.Children.Contains(child))
                {
                    parent.Children.Add(child);
                }
                if (!child.Parents.Contains(parent))
                {
                    child.Parents.Add(parent);
                }
            }

            Print(mainPerson);
        }

        private static void Print(string mainPersonInfo)
        {
            Person mainPerson = GetPerson(mainPersonInfo);

            Console.WriteLine($"{mainPerson.Name} {mainPerson.Birthday}");
            Console.WriteLine("Parents:");

            foreach (var parent in mainPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
            Console.WriteLine("Children:");

            foreach (var child in mainPerson.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }

        private static Person GetPerson(string input)
        {
            if (input.Contains('/'))
            {
                return people.FirstOrDefault(x => x.Birthday == input);
            }

            return people.FirstOrDefault(x => x.Name == input);
        }

        private static void Addmember(string input)
        {
            string[] inputArgs = input.Split();

            string name = inputArgs[0] + " " + inputArgs[1];
            string birthday = inputArgs[2];

            Person person = new Person(name, birthday);
            people.Add(person);
        }
    }
}
