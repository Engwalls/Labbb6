using System;
using System.Collections.Generic;
using System.Text;

namespace Labbb6
{
    class Pitbull : Dog  // Inherits from the class Dog
    {
        bool sitting;
        public Pitbull(bool sitting, string Name, string Mood, string Sound, int age, bool BeenFed)
        {
            this.sitting = sitting;     //Constructor
        }
        public Pitbull()
        {
            this.sitting = false;
        }
        public void Rolling()       // Method
        {
            Console.WriteLine("The pitbull is rolling around.");   // Print out info
        }
        public override void makeSound()     // Method
        {
            Console.WriteLine("The pitbull is whining.");  // Print out info
        }
    }
}
