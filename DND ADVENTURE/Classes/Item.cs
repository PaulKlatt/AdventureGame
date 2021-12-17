using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public class Item
    {
        public string Name { get; }

        //Not sure if this should be a dictionary with only 1 keyvalue pair, or just 2 properties.
        public string BonusType { get; set; } = null;

        public int BonusAmount { get; set; } = 0;
        
        public string Lore { get; }

        public Item(string name, string lore)
        {
            Name = name;
            Lore = lore;
        }
    }
}
