using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public static class Experience
    {
        public static int Level { get; set; } = 1;

        public static int Exp { get; set; } = 0;

        public static int ExperienceUntilNextLevel { get; set; } = 100;

        public static bool GainExp(int exp)
        {
            Exp += exp;
            if (exp >= ExperienceUntilNextLevel)
            {
                Exp -= ExperienceUntilNextLevel;
                Level++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
