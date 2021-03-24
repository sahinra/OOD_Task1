using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private double killChance;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, double killChance) : base(name, mana, manaRegen, spellPower)
        {
            this.killChance = killChance;
        }

        public new void Visit(Rat rat)
        {
            base.Visit(rat);
            if (rng.NextDouble() < killChance) 
            {
                Console.WriteLine($"{name} instantly kills {rat.Name}");
            }
        }
        
        public new void Visit(Ogre ogre)
        {
            base.Visit(ogre);
            if (rng.NextDouble() < killChance)
            {
                Console.WriteLine($"{name} instantly kills {ogre.Name}");
            }
        }

        public new void Visit(Giant giant)
        {
            base.Visit(giant);
            if (rng.NextDouble() < killChance)
            {
                Console.WriteLine($"{name} instantly kills {giant.Name}");
            }
        }
    }
}