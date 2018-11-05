using BirthdayCelebrations.Contracts;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthday;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Birthdate
        {
            get { return birthday; }
            private set { birthday = value; }
        }

    }
}
