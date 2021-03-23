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
            throw new NotImplementedException();
        }

        public void Visit(Ogre ogre)
        {
            throw new NotImplementedException();
        }

        public void Visit(Giant giant)
        {
            throw new NotImplementedException();
        }
    }
}