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
            if (rng.NextDouble() < rat.Speed / 100) 
            {
                Console.WriteLine($"{name} meets {rat.Name} with HP: {rat.HP}");
                rat.Damage(strength);
            }
        }

        public void Visit(Ogre ogre)
        {
            Console.WriteLine($"{name} meets {ogre.Name} with HP: {ogre.HP}");
            ogre.Damage(strength);
        }

        public void Visit(Giant giant)
        {
            Console.WriteLine($"{name} meets {giant.Name} with HP: {giant.HP}");
            giant.Damage(strength);
        }
    }
}