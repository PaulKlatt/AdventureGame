using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public abstract class Enemy
    {
        public string Name { get; set; }
        public HealthPoints HP { get; set; }
        public int ArmorClass { get; set; }
        public int Exp { get; set; }
        public int AttackBonus { get; set; }

        public abstract string GetAttack(int turnCount, out int attack, out int damage);

        public int RollDice()
        {
            Random die = new Random();
            int dieResult = die.Next(1, 20);
            return dieResult;
        }

    }
}
