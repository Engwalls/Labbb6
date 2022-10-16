using System;
using System.Collections.Generic;
using System.Text;

namespace Labbb6
{
    class GoldenRetriever : Dog   // Inherits from the class Dog
    {
        string color;
        public GoldenRetriever(string color, string Name, string Mood, string Sound, int age, bool BeenFed)
        {
            this.color = color;        // Constructor
        }
        public GoldenRetriever()
        {
            this.color = "golden";
        }
        public void BeingHappy()       // Method
        {
            Console.WriteLine("The golden retriever is being happy.");  // Print out info
        }
        public override void makeSound()   //Method
        {
            Console.WriteLine("The golden retriever is barking.");   // Print out info
        }
    }
}