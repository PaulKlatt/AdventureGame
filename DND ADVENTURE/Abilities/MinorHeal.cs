using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND_ADVENTURE.Classes;
using Attack = DND_ADVENTURE.Classes.Attack;

namespace DND_ADVENTURE.Abilities
{
    class MinorHeal : Ability
    {
        public override string Name { get; } = "Minor Heal";

        public override string Description { get; } = "Restore your HP equal to your Wisdom plus 2.";

        public override int Cooldown { get; set; }

        public override string Animation { get; } = "You focus your attention inwards for a brief moment, and feel recovery magic begin to stitch your wounds.";

        public override string PerformAbility(out string stat, out int effect)
        {
            effect = Player.Stats["WIS"] + 2;
            stat = "HP";
            return "SELF";
        }
    }
}
