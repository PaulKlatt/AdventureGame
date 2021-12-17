using DND_ADVENTURE.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Attacks
{
    public class PrecisionStrike : Attack
    {
        public override string Name { get; } = "Precision Strike";

        public override string Description { get; } = "Make an attack with your equipped weapon that crits on an 18 or higher. Cooldown: 4";

        public override int Cooldown { get; set; }

        public override string Animation { get; } = "You wait for an opening, then strike for a critical hit.";

        public override string PerformAttack(out int attack, out int damage)
        {
            int attackRoll = Player.RollDie();
            int critMod = 1;
            if (attackRoll >= 18)
            {
                critMod = 2;
            }
            attack = attackRoll + Player.Stats[Player.EquippedWeapon.BonusType];
            damage = critMod * Player.Stats[Player.EquippedWeapon.BonusType];
            Cooldown = 4;

            return Animation;
        }
    }
}
