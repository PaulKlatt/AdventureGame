using DND_ADVENTURE.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attack = DND_ADVENTURE.Classes.Attack;

namespace DND_ADVENTURE.Attacks
{
    public class PowerAttack : Attack
    {
        public override string Name { get; } = "Power Attack";

        public override string Description { get; } = "Make an attack at -2 with your equipped weapon to deal an extra 4 damage.  Cooldown: 4";

        public override int Cooldown { get; set; }

        public override string Animation { get; } = "You take a solid stance and abandon precision in order to inflict as much damage as possible.";

        public override string PerformAttack(out int attack, out int damage)
        {
            int attackRoll = Player.RollDie();
            int critMod = 1;
            if (attackRoll == 20)
            {
                critMod = 2;
            }
            attack = attackRoll + Player.Stats[Player.EquippedWeapon.BonusType] - 2;
            damage = critMod * Player.Stats[Player.EquippedWeapon.BonusType] + 4;
            Cooldown = 4;

            return Animation;
        }
    }
}
