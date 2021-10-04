using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    public class Saw : IDanger
    {
        public Dictionary<string, int> DangerTypes()
        {
            Dictionary<string, int> listOfDangers = new Dictionary<string, int>();
            listOfDangers.Add("Blade", 9);

            return listOfDangers;
        }
    }
}
