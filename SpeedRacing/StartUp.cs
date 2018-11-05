using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputCar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = inputCar[0];
                int fuelAmount = int.Parse(inputCar[1]);
                decimal fuelConsumption = decimal.Parse(inputCar[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = command[1];
                int distance = int.Parse(command[2]);

                Car currentCar = cars.Find(x => x.Model == model);
                currentCar.CanMove(distance);

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}
