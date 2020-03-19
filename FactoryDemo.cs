using System;

namespace Practice_Factory
{
    class FactoryDemo
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();
            IAnimal a1 = factory.GetAnimal("cat");
            Console.WriteLine("Animal 1 sound: " + a1.MakeSound());
            IAnimal a2 = factory.GetAnimal("dog");
            Console.WriteLine("Animal 2 sound: " + a2.MakeSound());
        }
    }
}
