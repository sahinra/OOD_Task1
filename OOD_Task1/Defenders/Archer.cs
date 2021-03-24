using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }
        public new void Visit(Rat rat)
        {
            base.Visit(rat);
            arrows--;
            Console.WriteLine($"{name} has {arrows} arrows");
        }

        public new void Visit(Ogre ogre)
        {
            base.Visit(ogre);
            arrows--;
            Console.WriteLine($"{name} has {arrows} arrows");
        }

        public new void Visit(Giant giant)
        {
            base.Visit(giant);
            arrows -= 2;
            Console.WriteLine($"{name} has {arrows} arrows losing 2 arrows");
        }
    }
}