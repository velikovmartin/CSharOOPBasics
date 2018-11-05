using BorderControl.Contracts;

namespace BorderControl
{
    class Citizen : IIdentifiable
    {
        private string name;
        private string id;
        private int age;
        private string birthday;

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
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

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

    }
}
