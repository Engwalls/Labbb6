using System;
using System.Collections.Generic;
using System.Text;

namespace Labbb6
{
    internal class Djur        // Class
    {
        //---------------------- Properties
        string Name;
        string Mood;
        string Sound;
        int age;
        bool BeenFed;
        public string name
        {
            get      //------------------ Get and Set
            {
                return Name;
            }
            set
            {
                if (value != "Albert")
                {
                    Name = "Unknown";
                }
                else
                {
                    Name = value;
                }
            }
        }
        public Djur(string Name, string Mood, string Sound, int age, bool BeenFed)   //Constructor
        {
            this.Name = Name;
            this.Mood = Mood;
            this.Sound = Sound;
            this.age = age;
            this.BeenFed = BeenFed;
        }
        public Djur()                           // Setting info
        {
            this.Name = "Erik";
            this.Mood = "Happy";
            this.Sound = "Quiet";
            this.age = 25;
            this.BeenFed = true;
        }
        public virtual void Eating()             //------------------------- Methods
        {
            Console.WriteLine("The animal is eating ");  // Print out info
        }
        public virtual void Sleeping()
        {
            Console.WriteLine("The animal is sleeping ");  // Print out info
        }
        public virtual void makeSound()
        {
            Console.WriteLine("The animal says: ");  // Print out info
        }
    }
}