
using System;

namespace ZooProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bosse", 3, 12, "Brun");
            Cat cat = new Cat("Misse", 2, 4, "Grå");
            Bird bird = new Bird("Kalle", 1, 1, "Gul");
            Bulldog bulldog = new Bulldog("Max", 4, 25, "Vit");
            Chihuahua chihuahua = new Chihuahua("Bella", 2, 3, "Svart");

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();
            bulldog.MakeSound();
            chihuahua.MakeSound();

            dog.Fetch();
            cat.Climb();
            bird.Fly();
            bulldog.Guard();
            chihuahua.BarkLoudly();
        }
    }
}
