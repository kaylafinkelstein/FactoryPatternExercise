using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public  static class AnimalFactory
    {
        public static IAnimals GetAnimal(int legCount)
        {
            switch (legCount)
            {
                case 2:
                    return new Bird();
                case 4:
                    return new Dog();
                default:
                    return null;
            }
        }
    }
}
