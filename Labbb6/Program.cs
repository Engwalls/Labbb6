using System;

namespace Labbb6
{
    class Program                                      //Erik Engvall NET22
    {
        static void Main(string[] args)
        {
            //------------------------- New objects
            Dog dog1 = new Dog("Chihuahua", "Sanna", "Cozy", "Loud", 24, true);
            Worm worm1 = new Worm("Long", "Albin", "Sad", "Silence", 2, false);
            Horse horse1 = new Horse();
            GoldenRetriever golden1 = new GoldenRetriever();
            Pitbull pitbull1 = new Pitbull();

            //----------------------- Get and Set
            Console.WriteLine(dog1.name);
            dog1.name = "Albert";
            Console.WriteLine(dog1.name);

            //-------------------- Calling the methods
            Console.WriteLine(" ");
            dog1.makeSound();
            dog1.Hunting();
            Console.WriteLine(" ");

            worm1.makeSound();
            worm1.Crawling();
            Console.WriteLine(" ");

            horse1.makeSound();
            horse1.Jumping();
            Console.WriteLine(" ");

            golden1.makeSound();
            golden1.BeingHappy();
            Console.WriteLine(" ");

            pitbull1.makeSound();
            pitbull1.Rolling();
        }
    }
}
