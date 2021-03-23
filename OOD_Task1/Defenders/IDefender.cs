using Enemies;

namespace Defenders
{
    interface IDefender
    {
        public void Visit(Rat rat);
        public void Visit(Ogre ogre);
        public void Visit(Giant giant);
    }
}