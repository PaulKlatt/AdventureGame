using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND_ADVENTURE.Attacks;
using DND_ADVENTURE.Classes;

namespace DND_ADVENTURE.Mangers
{
    public class AttackManager
    {
        public List<Attack> AvailableAttacks { get; set; } = new List<Attack>();

        //Gonna wanna reorganize this so it flows well.
        public AttackManager()
        {
            AvailableAttacks.Add(new BasicAttack());
           
            if (Player.Stats["STR"] >= 4)
            {
                AvailableAttacks.Add(new PowerAttack());
            }
            if (Player.Stats["DEX"] >= 4)
            {
                AvailableAttacks.Add(new PrecisionStrike());
            }
            
        }
        
    }
}
