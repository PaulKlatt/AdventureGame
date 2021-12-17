using DND_ADVENTURE.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Scenes
{
    public class OpeningTavernScene : Scene
    {
        public OpeningTavernNarrator Narrator { get; set; }

        public OpeningTavernScene(OpeningTavernNarrator narrator)
        {
            Narrator = narrator;
        }
        public override Scene RunScene()
        {

            Narrator.TitleScreen();

            //Need to see if its reasonable to set a property here that just takes in that player class
            //to save typing.  Maybe this class isnt needed at all?
            Player.SetPlayerName(Narrator.GetPlayerName());
            string strongestStat = Narrator.GetHighestStat();
            Player.ChangeStat(strongestStat, 4);
            Player.ChangeStat(Narrator.GetSmallStatBoost(), 2);
            Player.ChangeStat(Narrator.GetSmallStatBoost(), 2);
            Player.ChangeStat(Narrator.GetStatMinus(), -2);

            Player.CheckStats();
            Weapon startingWeapon = Narrator.GetStartingWeapon(strongestStat);
            Inventory.GainItem(startingWeapon);
            Player.EquippedWeapon = startingWeapon;
            return Narrator.GetNextScene();
            
        }

        //public List<string> GetAvailableOptions()
        //{
        //    //might not need this method at all, kind of a placeholder
        //    return null;
        //}
    }
}


