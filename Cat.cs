using System;

namespace ZooProject
{
    internal class Cat : Animal
    {
        public bool LikesToClimb { get; set; } = true;

        public Cat(string name, int age, double weight, string color)
            : base(name, age, weight, color)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " jamar: mjau!");
        }

        public void Climb()
        {
            Console.WriteLine(Name + " klättrar på ett träd.");
        }
    }
}
