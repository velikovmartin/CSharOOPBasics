using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string pizzaName)
        {
            this.Name = pizzaName;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        internal Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        internal List<Topping> Toppings
        {
            get { return toppings; }
            set
            {
                //if (toppings.Count > 10)
                //{
                //    throw new ArgumentException($"Number of toppings should be in range [0..10].");
                //}
                toppings = value;
            }
        }

        public void Add(Topping topping)
        {
            if (this.Toppings.Count >= 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            this.Toppings.Add(topping);
        }

        public double GetCalories { get => this.CaloriesCalculator();  }

        private double CaloriesCalculator()
        {
            double doughCalories = this.Dough.DoughCalories;
            double toppingCalories = this.Toppings.Sum(x => x.ToppingCalories);

            return doughCalories + toppingCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.GetCalories:F2} Calories.";
        }
    }
}
