using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;

        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }

            Console.WriteLine($"Mage {name} is recharging mana");
            RechargeMana();
            return false;
        }

        private void RechargeMana()
        {
            mana += manaRegen;
        }

        public void Visit(Rat rat)
        {
            Console.WriteLine($"{name} meets a {rat.Name}");
        }

        public void Visit(Ogre ogre)
        {
            Console.WriteLine($"{name} meets a {ogre.Name}");
        }

        public void Visit(Giant giant)
        {
            Console.WriteLine($"{name} meets a {giant.Name}");
        }
    }
}