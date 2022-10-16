using System;
using System.Collections.Generic;
using System.Text;

namespace Labbb6
{
    internal class Worm : Djur    //Inherits from the class Djur
    {
        string lenght;
        public Worm(string lenght, string Name, string Mood, string Sound, int age, bool BeenFed) : base(Name, Mood, Sound, age, BeenFed)
        {
            this.lenght = lenght;        //Constructor
        }
        public Worm()
        {
            this.lenght = "2";
        }
        public void Crawling()          // Method
        {
            Console.WriteLine("The worm is crawling.");  // Print out info
        }
        public override void makeSound()  // Method
        {
            Console.WriteLine("The worm says hello.");  // Print out info
        }
    }
}
