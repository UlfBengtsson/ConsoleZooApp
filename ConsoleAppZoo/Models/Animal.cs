using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public WeightUnit WeightUnit { get; set; }

        public Animal(string name, double weight, WeightUnit weightUnit)
        {
            Name = name;
            Weight = weight;
            WeightUnit = weightUnit;
        }

        public abstract string MakeNoise();

        public virtual string Info()
        {
            return $"--- {this.GetType().Name} Info ---\nName: {Name}\nWeight: {Weight} {WeightUnit}";
        }
    }
}
