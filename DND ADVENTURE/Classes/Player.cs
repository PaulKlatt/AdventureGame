using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public static class Player
    {
        public static string Name { get; private set; }

        public static HealthPoints HP { get; set; }

        public static Weapon EquippedWeapon { get; set; }

        public static int ArmorClass { get; set; } = 10;

        public static Dictionary<string, int> Stats { get; private set; } = new Dictionary<string, int>()
        {
            {"STR", 0 }, {"DEX", 0}, {"CON", 0}, {"INT", 0}, {"WIS", 0}, {"CHA", 0} };


        public static void CheckStats()
        {
            Console.WriteLine($"{Name}'s Stats");
            Console.WriteLine("Strength: " + Stats["STR"]);
            Console.WriteLine("Dexterity: " + Stats["DEX"]);
            Console.WriteLine("Constitution: " + Stats["CON"]);
            Console.WriteLine("Intelligence: " + Stats["INT"]);
            Console.WriteLine("Wisdom: " + Stats["WIS"]);
            Console.WriteLine("Charisma: " + Stats["CHA"]);

        }

        public static int RollDie()
        {
            Random die = new Random();
            int dieResult = die.Next(1, 20);
            return dieResult;
        }

        public static void SetPlayerName(string name)
        {
            Name = name;
        }
        public static void ChangeStat(string statToChange, int changeAmount)
        {
            Stats[statToChange] += changeAmount;
        }

        public static void DecideAttack()
        {

        }

    }
}
