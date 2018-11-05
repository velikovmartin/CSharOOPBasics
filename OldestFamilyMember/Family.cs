using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private static List<Person> people = new List<Person>();

        public static void AddMember(Person person) => people.Add(person);

        public static Person GetOldestMember()
        {
            int maxAge = people.Max(x => x.Age);
            return people.Find(x => x.Age == maxAge);
        }
    }
}
