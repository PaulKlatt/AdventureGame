using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public static class Inventory
    {

        public static List<Item> Bag = new List<Item>();
        public static void PrintInventory()
        {
            foreach (Item item in Bag)
            {
                //Need to deal with items without bonuses still
                Console.WriteLine($"{item.Name}: +{item.BonusAmount} to {item.BonusType}");
                Console.WriteLine(item.Lore);
                Console.WriteLine();
            }

        }

        public static void GainItem(Item loot)
        {
            Bag.Add(loot);
            if (!string.IsNullOrEmpty(loot.BonusType))
            {
                Player.ChangeStat(loot.BonusType, loot.BonusAmount);
            }
        }
    }
}
