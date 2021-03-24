using System;
using Enemies;

namespace Defenders
{
    class RatCatcher : IDefender
    {
        protected readonly string name;
        private bool hasRat;

        public RatCatcher(string name)
        {
            this.name = name;
            hasRat=false;
        }

        public void Visit(Rat rat)
        {
            if (!hasRat)
            {
                Console.WriteLine($"{name} meets {rat.Name} with HP: {rat.HP}");
                rat.isNotAlive();
                hasRat = true;
                Console.WriteLine($"{name} has a rat body");
            }
        }

        public void Visit(Ogre ogre)
        {
            if (hasRat)
            {
                Console.WriteLine($"{name} meets {ogre.Name} with HP: {ogre.HP}");
                ogre.isNotAlive();
            }
        }

        public void Visit(Giant giant)
        {
            if (!hasRat)
            {
                Console.WriteLine($"{name} meets {giant.Name} with HP: {giant.HP}");
                giant.isNotAlive();
            }
        }
    }
}