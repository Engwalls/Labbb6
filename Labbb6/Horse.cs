using System;
using System.Collections.Generic;
using System.Text;

namespace Labbb6
{
    internal class Horse : Djur             //Inherits from the class Djur
    {
        string height;
        public Horse(string height, string Name, string Mood, string Sound, int age, bool BeenFed) : base(Name, Mood, Sound, age, BeenFed)
        {
            this.height = height;           //Constructor
        }
        public Horse()
        {
            this.height = "150";
        }
        public void Jumping()                //Method
        {
            Console.WriteLine("The horse is jumping.");  // Print out info
        }
        public override void makeSound()     //Method
        {
            Console.WriteLine("The horse is neighing."); // Print out info
        }

    }
}
