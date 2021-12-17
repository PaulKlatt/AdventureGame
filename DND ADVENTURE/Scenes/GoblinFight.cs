using DND_ADVENTURE.Classes;
using DND_ADVENTURE.Enemies;
using DND_ADVENTURE.Narration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Scenes
{
    public class GoblinFight : BattleScene
    {

                //Might be able to make this a catch all scene for all battles, requires some thought
        public GoblinFight(BattleNarrator narrator, Goblin goblin) : base(narrator)
        {

        }

        public override Scene RunScene()
        {
            //base.RunBattle();
            return null;
        }
    }
}
