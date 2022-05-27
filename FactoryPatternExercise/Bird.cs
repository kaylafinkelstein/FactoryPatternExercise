using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Bird : IAnimals
    {
        public Bird()
        {

        }
        public void NumberOfLegs()
        {
            Console.WriteLine("The chicken is the closest living relative to the T-Rex."); 
        }
    }
}
