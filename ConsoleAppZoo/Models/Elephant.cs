using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    public class Elephant : Animal, IDanger
    {
        public int TusksLength { get; set; }
        public Elephant(int tuskLength,string name, double weight, WeightUnit weightUnit) : base(name, weight, weightUnit)
        {
            TusksLength = tuskLength;
        }

        public override string MakeNoise()
        {
            return "Whhiiieeee";
        }

        public override string Info()
        {
            return base.Info() + $"\nTusk length: {TusksLength}";
        }

        public Dictionary<string, int> DangerTypes()
        {
            Dictionary<string, int> listOfDangers = new Dictionary<string, int>();
            listOfDangers.Add("Trample", 9);
            listOfDangers.Add("Trunk", 4);
            listOfDangers.Add("Tusk", 9);

            return listOfDangers;
        }
    }
}
