using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = Console.ReadLine().Split(" ");
                string pizzaName = pizzaInput[1];
                Pizza pizza = new Pizza(pizzaName);
                string[] input = Console.ReadLine().Split(' ');
                while (input[0] != "END")
                {
                    string operation = input[0];
                    Topping topping;
                    Dough dough;
                    if (operation == "Dough")
                    { 
                        string flourType = input[1];
                        string bakingTechnique = input[2];
                        double weight = double.Parse(input[3]);
                        dough = new Dough(flourType, bakingTechnique, weight);
                        pizza.Dough = dough;
                    }
                    else
                    {
                        string toppingName = input[1];
                        double toppingAmount = double.Parse(input[2]);
                        topping = new Topping(toppingName, toppingAmount);
                        pizza.Add(topping);
                    }
                     
                    input = Console.ReadLine().Split(' ');
                }
                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
