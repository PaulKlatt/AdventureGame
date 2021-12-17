using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public class Weapon : Item
    {
        public bool IsEquipped { get; set; } = false;

        public string AttackAnimation { get; } 

        public Weapon(string name, string lore, string attackType, int bonusAmount, string attackAnimation) : base (name, lore)
        {
            BonusType = attackType;
            BonusAmount = bonusAmount;
            AttackAnimation = attackAnimation;
        }

        //Compare weapon method that compares to current weapon? 
    }
}
