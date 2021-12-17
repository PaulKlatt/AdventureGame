using DND_ADVENTURE.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Enemies
{
    public class Goblin : Enemy
    {
        public Goblin()
        {
            base.Name = "Goblin";
            base.HP = new HealthPoints(10);
            base.ArmorClass = 10;
            base.Exp = 100;
            base.AttackBonus = 1;
        }
        public override string GetAttack(int turnCount, out int attack, out int damage)
        {
            string animation;
            int critMod = 1;
            int attackRoll;
            attack = 0;
            damage = 0;
            if (turnCount % 4 == 1)
            {
                animation = "The goblin moves to attack, but stumbles and drops his scimitar.  He haphazardly scrambles to retrieve it.";
            }
            else if (turnCount % 4 == 2)
            {
                animation = "The goblin strikes suddenly!";
                attackRoll = RollDice();
                if (attackRoll == 20)
                {
                    critMod++;
                }
                attack = attackRoll + AttackBonus;
                damage = AttackBonus * critMod;
            }
            else if (turnCount % 4 == 3)
            {
                animation = "The goblin pulls back and winds up a mighty blow.";
            }
            else
            {
                animation = "The goblin unleashes a reckless attack!";
                attackRoll = RollDice();
                if (attackRoll == 20)
                {
                    critMod++;
                }
                attack = attackRoll + AttackBonus;
                damage = (AttackBonus + 3) * critMod;
            }
            return animation;
        }
    }
}
