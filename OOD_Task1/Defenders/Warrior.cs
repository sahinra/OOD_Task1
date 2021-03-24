using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }

        public void Visit(Rat rat)
        {
            Console.WriteLine($"{name} meets a {rat.Name}");
            rat.Speed -= strength;
            if (rng.NextDouble() < rat.Speed / 100) 
            {

            }
        }

        public void Visit(Ogre ogre)
        {
            Console.WriteLine($"{name} meets a {ogre.Name}");
            ogre.HP -= strength;
        }

        public void Visit(Giant giant)
        {
            Console.WriteLine($"{name} meets a {giant.Name}");
            giant.HP -= strength;
        }
    }
}