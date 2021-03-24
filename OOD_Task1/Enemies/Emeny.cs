using System;
using Defenders;

namespace Enemies
{
    abstract class Enemy
    {
        public string Name { get; }
        public bool Alive { get; private set; }
        public int HP { get; private set; }

        protected Enemy(string name, int hp)
        {
            Name = name;
            HP = hp;
            Alive = true;
        }

        public void Damage(int damage)
        {
            GetDamage(damage);
        }

        public void isNotAlive()
        {
            Alive = false;
            Console.WriteLine($"{Name} is dead...");
        }

        protected void GetDamage(int damage)
        {
            HP -= damage;
            Console.WriteLine($"{Name} lost {damage} health power");

            if (HP<=0)
            {
                Console.WriteLine($"{Name} is dead...");
                Alive = false;
            }
        }

        public abstract void Accept(IDefender defender);
    }
}