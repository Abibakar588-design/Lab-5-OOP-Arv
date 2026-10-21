
using System;

namespace ZooProject
{
    internal class Bulldog : Dog
    {
        public bool IsStrong { get; set; } = true;

        public Bulldog(string name, int age, double weight, string color)
            : base(name, age, weight, color)
        {
        }

        public void Guard()
        {
            Console.WriteLine(Name + " vaktar området.");
        }
    }
}
