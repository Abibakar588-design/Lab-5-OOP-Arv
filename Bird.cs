
using System;

namespace ZooProject
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; } = true;

        public Bird(string name, int age, double weight, string color)
            : base(name, age, weight, color)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " kvittrar: pip pip!");
        }

        public void Fly()
        {
            Console.WriteLine(Name + " flyger.");
        }
    }
}
