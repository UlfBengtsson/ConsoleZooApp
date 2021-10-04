using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    public class Tiger : Animal, IDanger
    {

        public string FurColor { get; set; }
        public string StripesColor { get; set; }

        public Tiger(string furColor, string stripesColor,string name, double weight, WeightUnit weightUnit) : base(name,weight,weightUnit)
        {
            FurColor = furColor;
            StripesColor = stripesColor;
        }

        public override string MakeNoise()
        {
            return "Raawwrrr";
        }

        public override string Info()
        {
            return base.Info() + $"\nFur: {FurColor} with {StripesColor} stripes";
        }

        public Dictionary<string, int> DangerTypes()
        {
            Dictionary<string, int> listOfDangers = new Dictionary<string, int>();
            listOfDangers.Add("Claws", 9);
            listOfDangers.Add("Bite", 7);

            return listOfDangers;
        }
    }
}
