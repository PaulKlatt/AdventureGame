using System;
using DND_ADVENTURE.Classes;
using DND_ADVENTURE.Scenes;
using System.Collections.Generic;
using System.Linq;

namespace DND_ADVENTURE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OpeningTavernNarrator narrator = new OpeningTavernNarrator();
                OpeningTavernScene openingScene = new OpeningTavernScene(narrator);
                

                //Look into font changes? Look into centering? Look into setting window size? Look into better than default colors?
                
                Scene sceneTwo = openingScene.RunScene();

                Scene sceneThree = sceneTwo.RunScene();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Whelp, fucked something up... {ex.Message}");
            }

    }
}
}
