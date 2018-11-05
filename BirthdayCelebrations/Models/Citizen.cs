using BirthdayCelebrations.Contracts;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IIdentifiable, IBirthable
    {
        private string name;
        private string id;
        private int age;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string Birthdate
        {
            get { return birthdate; }
            private set { birthdate = value; }
        }
         
    }
}
