using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Dough
    {
        private const double White = 1.5;
        private const double Wholegrain = 1.0;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;
        private const int BaseCal = 2;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get { return flourType; }
            set
            {
                if (value.ToLower() != "white" && 
                    value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value.ToLower();
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && 
                    value.ToLower() != "chewy" && 
                    value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value.ToLower();
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double DoughCalories { get => this.CaloriesCalculator(); }

        private double CaloriesCalculator()
        {
            double flourModifier = this.FlourType == "white" ? White : Wholegrain;
            double bakingModifier = this.BakingTechnique == "crispy" ? Crispy :
                (this.BakingTechnique == "chewy" ? Chewy : Homemade);
            
            return BaseCal * flourModifier * bakingModifier * Weight;
        }
    }
}
