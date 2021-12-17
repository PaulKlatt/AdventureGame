using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public static class GenericTextGrab
    {
        //public readonly static string Intro = ""; 
        //Not sure if these should be attributes or methods
        public static void SickAsciiSword()
        {
            Console.WriteLine("          /\\");
            Console.WriteLine("         //\\\\");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("         ||||");
            Console.WriteLine("      _  ||||  _");
            Console.WriteLine("     /(  ||||  )\\");
            Console.WriteLine("     \\\\\\_[\\/]_///");
            Console.WriteLine("      \\\\< () >// ");
            Console.WriteLine("       \\/[\\\\]\\/  ");
            Console.WriteLine("         [//]    ");
            Console.WriteLine("         [\\\\]    ");
            Console.WriteLine("         [//]    ");
            Console.WriteLine("         [\\\\]    ");
            Console.WriteLine("         [//]    ");
            Console.WriteLine("         (__)    ");
        }

        public static void StatDescription()
        {
            Console.WriteLine("The basic stats for any adventurer:");
            Console.WriteLine("STRENGTH(STR): brute physical force, used for athletics, lifting, or bursts of power.");
            Console.WriteLine("DEXTERITY(DEX): body control, reflexes, and agility, used for sleight of hand and balance.");
            Console.WriteLine("CONSTITUTION(CON): vitality and endurance, used to maintain healthiness and resist fatigue.");
            Console.WriteLine("INTELLIGENCE(INT): logic, analysis, and book smarts, used to recall knowledge or make critical connections");
            Console.WriteLine("WISDOM(WIS): awareness and insight, used to understand the disposition of others or clearly perceive surroundings.");
            Console.WriteLine("CHARISMA(CHA): confidence and charm, used to convince, deceive or captivate others.");

        }

        public static void OpeningTavernIntro()
        {
            Console.Clear();
            //Need to figure out how to space this right, maybe i set the window size and then figure out where the breaks go?
            //Dynamically resizing and replacing the window as different things happen might be a good way to emphasize stuff
            Console.WriteLine("You open your eyes to almost stark darkness.  As you try to blink away the fuzziness," +
                "you realize the blur refuses \n to subside.  Though there is no light source, you can vaguely make out " +
                "shapes, figures, tables, chairs, a bar.  \n This looks like a medieval tavern.  The thought alerts you to the low" +
                "background hum of chatter and the light clink \n of glasses.  However, as you focus on the noise, the scenery obscures " +
                "to mist.  As you squint at the scenery, \n the noise quiets to a barely perceivable murmer.  You glance downward " +
                "to take in your bearings and realize \n you can't see any part of yourself.  Before you have a chance to react to the " +
                "rising panic you begin to feel,\n a booming sourceless voice floods your consciousness.  ");
        }

        public static void OpeningTavernOutro()
        {
            Console.WriteLine("As your grip tightens around the item, the mists slowly begin to disperse.  You are left in a completely dark " +
                "void, eerily silent.  The voice and presence recede from your mind, but leave you with some final parting words.");
            Console.ReadKey();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("GOOD LUCK ADVENTURER");

            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The abrupt screech of an earsplitting scream shoots your eyes open.  You don't remember closing them. You find yourself " +
                "blinking against the bright light.  Before you can register your surroundings, a short figure fills your vision as it lunges at you!");
            Console.WriteLine();
            Console.WriteLine("You dive out of the way and put a bit of distance between yourself and the figure.  Short, lithe frame. Ragged " +
                "brown armor. Pointed ears, bulbous nose, sharp teeth, yellow eyes.  Greenish leathery skin.  This is clearly a goblin. As you wonder why " +
                "the thought isn't more alarming to you, your hands brandish your weapon in an inexplicably comfortable familiarity and your feet rest into a battle stance.");
            Console.WriteLine("I guess you're an adventurer now.");
        }

        public static void GoblinAscii()
        {
            Console.WriteLine("          ,      ,         ");
            Console.WriteLine("         /(.-\"\"-.)\\        ");
            Console.WriteLine("     |\\  \\/      \\/  /|    ");
            Console.WriteLine("     | \\ / =.  .= \\ / |    ");
            Console.WriteLine("     \\ (\\   o\\/o   / )/    ");
            Console.WriteLine("      \\_, '-/  \\-' ,_/     ");
            Console.WriteLine("        /   \\__/   \\       ");
            Console.WriteLine("        \\ \\__/\\__/ /       ");
            Console.WriteLine("      ___\\ \\|--|/ /___     ");
            Console.WriteLine("     /`   \\      /    `\\   ");
            Console.WriteLine("    /      '----'       \\  ");
        }
    }
}
