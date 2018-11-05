using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

                string[] inputPeopleData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                string[] inputProductsData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < inputPeopleData.Length; i++)
                {
                    var currentInput = inputPeopleData[i].Split('=');
                    var currentPersonName = currentInput[0];
                    var currentPersonMoney = decimal.Parse(currentInput[1]);
                    var person = new Person(currentPersonName, currentPersonMoney);
                    people.Add(person);
                }


                for (int i = 0; i < inputProductsData.Length; i++)
                {
                    var currentInput = inputProductsData[i].Split("=");
                    var currentProductName = currentInput[0];
                    var currentProductCost = decimal.Parse(currentInput[1]);
                    var product = new Product(currentProductName, currentProductCost);
                    products.Add(product);
                }

                var inputPurchases = Console.ReadLine();

                while (inputPurchases != "END")
                {
                    var purchase = inputPurchases.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var buyer = purchase[0];
                    var product = purchase[1];

                    Product currentProduct = products.Find(x => x.Name == product);

                    people.Find(x => x.Name == buyer).Add(currentProduct);

                    inputPurchases = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
