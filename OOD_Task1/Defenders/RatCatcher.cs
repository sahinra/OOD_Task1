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