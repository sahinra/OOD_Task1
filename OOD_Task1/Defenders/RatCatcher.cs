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
                Console.WriteLine($"{name} meets a {rat.Name}");
                rat.Alive = false;
                hasRat = true;
                Console.WriteLine($"{name} has a rat body");
            }
        }

        public void Visit(Ogre ogre)
        {
            if (hasRat)
            {
                Console.WriteLine($"{name} meets a {ogre.Name}");
                ogre.Alive = false;
            }
        }

        public void Visit(Giant giant)
        {
            if (!hasRat)
            {
                Console.WriteLine($"{name} meets a {giant.Name}");
                giant.Alive = false;
                hasRat = true;
            }
        }
    }
}