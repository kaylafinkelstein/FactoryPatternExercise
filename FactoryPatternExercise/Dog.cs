using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Dog : IAnimals
    {
        public Dog()
        {

        }
        public void NumberOfLegs()
        {
            Console.WriteLine("Dogs sense of smell is at least 40 times stronger than ours!");
        }
    }
}
