using DND_ADVENTURE.Classes;
using DND_ADVENTURE.Managers;
using DND_ADVENTURE.Mangers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Narration
{
    public class BattleNarrator : Narrator
    {
        public Enemy Enemy { get; }
        public List<Attack> AttackList { get; }

        public List<Ability> AbilityList { get; }

        public BattleNarrator(Enemy enemy)
        {
            Enemy = enemy;
            AttackList = new AttackManager().AvailableAttacks;
        }

        public override Scene GetNextScene()
        {
            throw new NotImplementedException();
        }

        public void StartBattle()
        {
            Console.WriteLine($"A wild {Enemy} appears! \n What would you like to do?");
            Console.WriteLine();
        }

        public void DisplayBattleUI()
        {
            Console.WriteLine(Enemy.Name + ": " + Enemy.HP.HPBar);
            Console.WriteLine();
            AsciiManager.DisplayAscii(Enemy.Name);
            Console.WriteLine();
            Console.WriteLine(Player.Name + ": " + Player.HP.HPBar);

        }

        public int DisplayMainBattleMenu()
        {
            Console.WriteLine("PLEASE ENTER THE NUMBER OF AN AVAILABLE ACTION");
            Console.WriteLine("");
            Console.WriteLine("(1) ATTACK");
            Console.WriteLine("(2) ABILITY");
            Console.WriteLine("(3) ITEM");
            Console.WriteLine("(0) HELP");

            string response = Console.ReadLine();
            int validChoice = -1;
            int.TryParse(response, out validChoice);

            while (validChoice >= 0 || validChoice <= 3)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice.  Please choose one of the number options listed above.");
                response = Console.ReadLine();
                int.TryParse(response, out validChoice);
            }

            return validChoice;
        }
    }
}
