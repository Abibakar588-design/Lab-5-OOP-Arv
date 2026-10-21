
using System;

namespace ZooProject
{
    internal class Chihuahua : Dog
    {
        public bool IsSmall { get; set; } = true;

        public Chihuahua(string name, int age, double weight, string color)
            : base(name, age, weight, color)
        {
        }

        public void BarkLoudly()
        {
            Console.WriteLine(Name + " skäller högt!");
        }
    }
}
