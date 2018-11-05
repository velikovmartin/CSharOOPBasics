using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        // model, fuel amount, fuel consumption for 1 kilometer and  traveled distance. 

        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private int distance;

        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public decimal FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public decimal FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        internal void CanMove(int distance)
        {
            if (this.FuelAmount < distance * this.FuelConsumption)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.Distance += distance;
                var fuelConsumed = distance * this.FuelConsumption;
                this.FuelAmount -= fuelConsumed;
            }
        }
    }
}
