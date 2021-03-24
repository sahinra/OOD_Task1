using System;
using Defenders;

namespace Enemies
{
    class Ogre : Enemy
    {
        private int armor;
        public int Armor { get => armor; }

        public Ogre(string name, int hp, int armor) : base(name, hp)
        {
            this.armor = armor;
        }

        public override void Accept(IDefender defender)
        {
            Console.WriteLine($"{Name} attacks..");
            defender.Visit(this);
        }

        protected new void GetDamage(int damage)
        {
            base.GetDamage(damage);
            armor -= damage;
            Console.WriteLine($"The number of armors of {Name} decreased by {damage}..");
        }
    }
}