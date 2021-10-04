using ConsoleAppZoo.Models;
using System;

namespace ConsoleAppZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Orange", "Black", "Cain", 220, WeightUnit.Kg);

            //Console.WriteLine(tiger.Info());
            //Console.WriteLine(tiger.MakeNoise());

            Elephant elephant = new Elephant(22, "Dumbo", 2.2, WeightUnit.Tons);

            //Console.WriteLine(elephant.Info());
            //Console.WriteLine(elephant.MakeNoise());

            Animal[] zooAnimals = new Animal[] { elephant, tiger };

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
            }
        }
    }
}
