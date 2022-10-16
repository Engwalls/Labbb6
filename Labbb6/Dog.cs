using System;
using System.Collections.Generic;
using System.Text;

namespace Labbb6
{
    internal class Dog : Djur   //Inherits from the class Djur
    {
        string Breed;
        public Dog(string Breed, string name, string Mood, string Sound, int age, bool BeenFed) : base(name, Mood, Sound, age, BeenFed)
        {
            this.Breed = Breed;        //Constructor
        }
        public Dog()
        {
            this.Breed = "Rottweiler";
        }
        public void Hunting()   //Method
        {
            Console.WriteLine("The dog is hunting.");  // Print out info
        }
        public override void makeSound()    // Method
        {
            Console.WriteLine("The dog says woooofff.");  // Print out info
        }
    }
}
