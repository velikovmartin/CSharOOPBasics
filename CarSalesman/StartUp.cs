using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static List<Car> cars;

        static void Main(string[] args)
        {
            cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputEngines = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = inputEngines[0];
                var power = int.Parse(inputEngines[1]);
                Engine engine = new Engine(model, power);
                engines.Add(engine);

                if (inputEngines.Length == 3)
                {
                    if (int.TryParse(inputEngines[2], out var output))
                    {
                        engine.Displacement = output;
                    }
                    else
                    {
                        engine.Efficiency = inputEngines[2];
                    }
                }

                if (inputEngines.Length == 4)
                {
                    engine.Displacement = int.Parse(inputEngines[2]);
                    engine.Efficiency = inputEngines[3];
                }
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] inputCars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = inputCars[0];
                var en = inputCars[1];
                Engine engine = engines.Find(x => x.Model == en);
                Car car = new Car(model, engine);
                cars.Add(car);

                if (inputCars.Length == 3)
                {
                    if (int.TryParse(inputCars[2], out var output))
                    {
                        car.Weight = output;
                    }
                    else
                    {
                        car.Color = inputCars[2];
                    }
                }

                if (inputCars.Length == 4)
                {
                    car.Weight = int.Parse(inputCars[2]);
                    car.Color = inputCars[3];
                }
            }
            Print();
        }

        private static void Print()
        {
            foreach (var car in cars)
            {
                
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                
                if (car.Engine.Displacement != -1)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {"n/a"}");
                }
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight != -1)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: {"n/a"}");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
