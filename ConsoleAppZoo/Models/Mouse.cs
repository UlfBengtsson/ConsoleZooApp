using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    public class Mouse : Animal
    {
        public int TailLength { get; set; }

        public Mouse(int tailLength,string name, double weight, WeightUnit weightUnit) : base(name, weight, weightUnit)
        {
            TailLength = tailLength;
        }


        public override string MakeNoise()
        {
            return "Squikk";
        }
    }
}
