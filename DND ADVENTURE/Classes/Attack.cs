﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public abstract class Attack
    {
        
        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract int Cooldown { get; set; }

        public abstract string Animation { get; }

        public abstract string PerformAttack(out int attack, out int damage);
 
    }
}
