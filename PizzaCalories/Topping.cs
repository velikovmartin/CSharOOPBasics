using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int BaseCal = 2;

        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;

        private string toppingName;
        private double toppingAmount;

        public Topping(string toppingName, double toppingAmount)
        {
            this.ToppingName = toppingName;
            this.ToppingAmount = toppingAmount;
        }

        public string ToppingName
        {
            get { return toppingName; }
            set
            {
                if (value.ToLower() != "meat" &&
                    value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" &&
                    value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppingName = value;
            }
        }

        public double ToppingAmount
        {
            get { return toppingAmount; }
            set
            {
                if (value < 1 || value > 50)
                {
                    //string type = Char.ToUpper(this.ToppingName[0]) + this.ToppingName.Substring(1);
                    throw new ArgumentException($"{this.ToppingName} weight should be in the range [1..50].");
                }
                toppingAmount = value;
            }
        }
        public double ToppingCalories { get => this.CaloriesCalculator(); }

        private double CaloriesCalculator()
        {
            double modifier = this.ToppingName.ToLower() == "meat" ? Meat :
                (this.ToppingName.ToLower() == "veggies" ? Veggies :
                (this.ToppingName.ToLower() == "cheese" ? Cheese : Sauce));
            return BaseCal * modifier * this.ToppingAmount;
        }
    }
}
