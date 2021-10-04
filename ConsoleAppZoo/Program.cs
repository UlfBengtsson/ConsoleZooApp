using ConsoleAppZoo.Models;
using System;
using System.Collections.Generic;

namespace ConsoleAppZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zoo();
            //Modelus();
        }//end of main

        static void Zoo()
        {
            Tiger tiger = new Tiger("Orange", "Black", "Cain", 220, WeightUnit.Kg);

            //Console.WriteLine(tiger.Info());
            //Console.WriteLine(tiger.MakeNoise());

            Elephant elephant = new Elephant(22, "Dumbo", 2.2, WeightUnit.Tons);

            //Console.WriteLine(elephant.Info());
            //Console.WriteLine(elephant.MakeNoise());

            Animal animalMouse = new Mouse(5, "Miky", 22, WeightUnit.grams);

            Animal[] zooAnimals = new Animal[] { elephant, tiger, animalMouse };

            List<IDanger> dangerZone = new List<IDanger>();

            foreach (Animal animal in zooAnimals)
            {
                Console.WriteLine(animal.Info());
                //if (animal is Tiger)
                //{
                //    Console.WriteLine((animal as Tiger).Info());
                //}
                //else if (animal is Elephant)
                //{
                //    Console.WriteLine((animal as Elephant).Info());
                //}
                //else
                //{
                //    Console.WriteLine(animal.Info());
                //}

                if (animal is IDanger)
                {
                    dangerZone.Add((animal as IDanger));
                }
            }

            Console.WriteLine("\nDanger Zone of the Zoo\n");

            dangerZone.Add(new Saw());

            foreach (IDanger danger in dangerZone)
            {
                Console.WriteLine(danger.GetType().Name);
                foreach (var item in danger.DangerTypes())
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }

        static void Modelus()
        {
            int paid = 12;
            int mod = 5;
            int result = 0;

            result = paid % mod;

            Console.WriteLine(result);
        }
    }
}
