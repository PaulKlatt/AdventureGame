using DND_ADVENTURE.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Managers
{
    public static class AsciiManager
    {
        public static void DisplayAscii(string name)
        {
            if (name == "sword")
            {
                GenericTextGrab.SickAsciiSword();
            }
            else if (name == "Goblin")
            {
                GenericTextGrab.GoblinAscii();
            }
            else
            {

            }
        }
    }
}
