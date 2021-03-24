using System;
using Defenders;

namespace Enemies
{
    class Rat : Enemy
    {
        private int speed;
        public int Speed { get => speed; }

        public Rat(string name, int hp, int speed) : base(name, hp)
        {
            this.speed = speed;
        }

        public override void Accept(IDefender defender)
        {
            Console.WriteLine($"{Name} attacks..");
            defender.Visit(this);
        }

        protected new void GetDamage(int damage)
        {
            base.GetDamage(damage);
            speed += damage;
            Console.WriteLine($"The speed of {Name} increased by {damage}..");
        }
    }
}