using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class People
    {
        private static List<Person> people = new List<Person>();

        public static void AddMember(Person person) => people.Add(person);

        public static List<Person> GetPeopleAgedOverThirty()
        {
            var peopleOver30 = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            return peopleOver30;
        }
    }
}
