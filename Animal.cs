
using System;

namespace ZooProject
{
    internal class Animal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 1;
        public double Weight { get; set; } = 1;
        public string Color { get; set; } = "Unknown";
        public bool IsHungry { get; set; } = true;

        public Animal(
            string name = "Unknown",
            int age = 1,
            double weight = 1,
            string color = "Unknown")
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public void Eat()
        {
            IsHungry = false;
            Console.WriteLine(Name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " is sleeping");
        }

        public void Move()
        {
            Console.WriteLine(Name + " is moving");
        }
    }
}
