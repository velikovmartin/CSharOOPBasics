using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> Bag
        {
            get { return bag; }
            set { bag = value; }
        }

        public void Add(Product product)
        {
            decimal cost = product.Cost;
            string productName = product.Name;

            if (cost > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {productName}");
            }
            else
            {
                this.Bag.Add(product);
                this.Money -= cost;
                Console.WriteLine($"{this.Name} bought {productName}");
            }
        }

        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            else
            {
                return $"{this.Name} - {string.Join(", ", Bag.Select(x => x.ToString()))}";
            }
        }
    }
}
