using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND_ADVENTURE.Classes;
using DND_ADVENTURE.Enemies;
using DND_ADVENTURE.Managers;
using DND_ADVENTURE.Narration;
using DND_ADVENTURE.Scenes;

namespace DND_ADVENTURE
{
    public class OpeningTavernNarrator : Narrator
    {
        private string RemainingOptions { get; set; } = "STR|DEX|CON|INT|WIS|CHA";

        private List<string> AvailableStats
        {
            get
            {
                return RemainingOptions.Split("|").ToList<string>();
            }
        }

        private int smallBoostsLeft = 2;

        public void TitleScreen()
        {
            Console.WriteLine("//////////////////////////");
            Console.WriteLine("  THE JANK DND ADVENTURE  ");
            Console.WriteLine("//////////////////////////");
            AsciiManager.DisplayAscii("sword");
            Console.WriteLine("When the text pauses and you have finished reading, please press any key to commence your adventure!");
            Console.ReadKey();
            GenericTextGrab.OpeningTavernIntro();
            Console.ReadKey();
        }


        public string GetPlayerName()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("BEFORE YOU BEGIN YOUR ADVENTURE TELL ME ABOUT YOURSELF.");
            Console.WriteLine();
            Console.WriteLine("WHAT IS YOUR NAME?");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine().Trim(' ');
            //Considering putting a boolean that changes to false when they mess up an input. Then putting a 
            //message that thanks them for not messing up at the end if its still true. Maybe even an int that
            //ticks up, then gives them some crap, maybe even closes the console if they mess up too much?
            //Feels like a fun way to add some personality here. (maybe remove intelligence from stat boosts and
            //automatically assign it to the minus stat)


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"PLEASURE TO MEET YOU {name.ToUpper()}.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return name;
        }

        public string GetHighestStat()
        {
            Console.WriteLine("As you try to comprehend what's happening, knowledge flows unbidden to your mind.");
            Console.WriteLine();
            GenericTextGrab.StatDescription();
            Console.WriteLine();

            Console.WriteLine("Options: " + RemainingOptions);
            Console.WriteLine("Which of the above stats do you feel best describes you?");
            Console.WriteLine("Please answer in the form of a three letter abbreviation above.");
            string strongestStat = Console.ReadLine().ToUpper();
            while (!AvailableStats.Contains(strongestStat))
            {
                Console.WriteLine("Invalid entry.  Please use one of the abbreviations listed.");
                Console.WriteLine("Example: " + RemainingOptions);
                strongestStat = Console.ReadLine().ToUpper();
            }
            if (strongestStat == AvailableStats[AvailableStats.Count - 1])
            {
                RemainingOptions = RemainingOptions.Replace($"|{strongestStat}", "");
            }
            else
            {
                RemainingOptions = RemainingOptions.Replace($"{strongestStat}|", "");
            }
            Console.Clear();
            Console.WriteLine($"You have selected {strongestStat}.");
            Console.WriteLine();
            Console.WriteLine("Before your vision, a large ornate mirror apparates from the mist.  As you choose a strength," +
                " a figure begins to form.");
            Console.WriteLine();
            return strongestStat;
            //SET THE STAT BOOST IN PLAYER
        }

        public string GetSmallStatBoost()
        {
            GenericTextGrab.StatDescription();
            Console.WriteLine();

            Console.WriteLine("Remaining Options: " + RemainingOptions);
            Console.WriteLine($"Which of the remaining stats do you feel you have a knack for? ({smallBoostsLeft} boosts left)");
            Console.WriteLine();

            string boost = Console.ReadLine().ToUpper();
            while (!AvailableStats.Contains(boost))
            {
                Console.WriteLine("Invalid entry.  Please use one of the abbreviations listed.");
                Console.WriteLine("Example: " + RemainingOptions);
                boost = Console.ReadLine().ToUpper();
            }

            if (boost == AvailableStats[AvailableStats.Count - 1])
            {
                RemainingOptions = RemainingOptions.Replace($"|{boost}", "");
            }
            else
            {
                RemainingOptions = RemainingOptions.Replace($"{boost}|", "");
            }
            smallBoostsLeft--;

            Console.Clear();
            Console.WriteLine($"You have selected {boost}.");
            Console.WriteLine();
            return boost;
            //SET THE STAT BOOST IN PLAYER
        }

        public string GetStatMinus()
        {
            //consider moving these out of this method.  Maybe all I need is a change stat method and this has the prompts
            GenericTextGrab.StatDescription();
            Console.WriteLine();
            Console.WriteLine("Remaining Options: " + RemainingOptions);
            Console.WriteLine("Which of the remaining stats do you feel you have a weakness in or struggle at?");
            Console.WriteLine();

            string minus = Console.ReadLine().ToUpper();
            while (!AvailableStats.Contains(minus))
            {
                Console.WriteLine("Invalid entry.  Please use one of the abbreviations listed.");
                Console.WriteLine("Example: " + RemainingOptions);
                minus = Console.ReadLine().ToUpper();
            }

            Console.Clear();
            Console.WriteLine($"You have selected {minus}.");
            Console.WriteLine();
            Console.WriteLine("The figure in the mirror clarifies into focus, undeniably you, but maybe not exactly true to life.  You find the image you form of yourself" +
                " changes the figure until you realize it has stopped adjusting.  You glance down and realize you have a body again, one that matches the image." );
            Console.WriteLine();
            return minus;
        }

        public Weapon GetStartingWeapon(string strongestStat)
        {
            Console.WriteLine("The voice resounds in the deepest corners of your mind once more.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("IT'S DANGEROUS TO GO ALONE. TAKE THIS.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.WriteLine();
            string lore = "The weapon bestowed upon you at the start of your adventure.";
            Weapon startingWeapon;
            int weaponTypeIndex = 13;
            if (strongestStat == "STR")
            {
                startingWeapon = new Weapon("Adventurer's Maul", lore, strongestStat, 1, "You tighten the grip of your mighty maul before swinging it in an arcing, overhead smash. " +
                    " Gravity and your strength bring it rocketing towards your enemy."); 
            }
            else if (strongestStat == "DEX")
            {
                startingWeapon = new Weapon("Adventurer's Dagger", lore, strongestStat, 1, "The dagger dances between your hands, striking out towards your enemy " +
                    "with a nimble thrust, a flashing stab, an agile slash.");
            }
            else if (strongestStat == "CON")
            {
                startingWeapon = new Weapon("Adventurer's Maul", lore, "STR", 1, "You tighten the grip of your mighty maul before swinging it in an arcing, overhead smash. " +
                    " Gravity and your strength bring it rocketing towards your enemy.");
            }
            else if (strongestStat == "INT")
            {
                startingWeapon = new Weapon("Adventurer's Tome", lore, strongestStat, 1, "As you turn the pages and chant the runes inscribed in the tome, purple bolts " +
                    "of force slowly rise around you, then suddenly barrel towards your enemy.");
            }
            else if (strongestStat == "WIS")
            {
                startingWeapon = new Weapon("Adventurer's Staff", lore, strongestStat, 1, "With practiced ease, your staff twirls to strike your enemy, leaving trails " +
                    "magic in its wake.");
            }
            else
            {
                startingWeapon = new Weapon("Adventurer's Wand", lore, strongestStat, 1, "With a flick of your wrist, burning sparks burst from the wand and " +
                    "assail your enemy.");
            }
            Console.WriteLine("The mirror dissolves to mist once more and rapidly condenses in a smaller shape directly before you." +
                                "  Without hesitation, your newly formed hands grasp the vapors as they solidify into a rustic but beautiful " +
                                $"{startingWeapon.Name.Substring(weaponTypeIndex)}.");
            return startingWeapon;
        }

        public override Scene GetNextScene()
        {

            GenericTextGrab.OpeningTavernOutro();
            Goblin goblin = new Goblin();
            BattleNarrator goblinBattleNarrator = new BattleNarrator(goblin);
            BattleScene goblinFight = new BattleScene(goblinBattleNarrator);

            return goblinFight;
        }
    }
}
