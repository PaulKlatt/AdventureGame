using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND_ADVENTURE.Classes;

namespace DND_ADVENTURE.Attacks
{

    public class BasicAttack : Attack
    {
        public override string Name { get; } = "Basic Attack";

        public override string Description { get; } = "Make an attack with your equipped weapon.";

        public override int Cooldown { get; set; } = 0;

        public override string Animation
        {
            get
            {
                return Player.EquippedWeapon.AttackAnimation;
            }
        }

        public override string PerformAttack(out int attack, out int damage)
        {
            {
                int attackRoll = Player.RollDie();
                int critMod = 1;
                if (attackRoll == 20)
                {
                    critMod = 2;
                }
                attack = attackRoll + Player.Stats[Player.EquippedWeapon.BonusType];
                damage = critMod * Player.Stats[Player.EquippedWeapon.BonusType];

                return Animation;
            }
        }

    }
}
