using System;

namespace ZooProject
{
    internal class Dog : Animal
    {
        public string Breed { get; set; } = "Blandras";

        public Dog(string name, int age, double weight, string color)
            : base(name, age, weight, color)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " skäller: Voff!");
        }

        public void Fetch()
        {
            Console.WriteLine(Name + " hämtar en boll.");
        }
    }
}