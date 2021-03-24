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
        }

        public new void Visit(Ogre ogre)
        {
            base.Visit(ogre);
            arrows--;
        }

        public new void Visit(Giant giant)
        {
            base.Visit(giant);
            arrows -= 2;
        }
    }
}