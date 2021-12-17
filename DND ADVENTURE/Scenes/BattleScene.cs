
using DND_ADVENTURE.Narration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public class BattleScene : Scene
    {
        public BattleNarrator Narrator { get; set; }

        public int TurnCount { get; set; } = 1;

        // Ability list might have to be in narrator, pretty sure they need the list to present to the console


        public BattleScene(BattleNarrator narrator)
        {
            Narrator = narrator;
        }


        //Might have to split this up into a series of rounds
        public int RunBattle()
        {
            Narrator.DisplayBattleUI();
            int response = Narrator.DisplayMainBattleMenu();


            int enemyDamage;
            int enemyAttack;
            string enemyAnimation;
            int playerDamage;
            int playerAttack;
            string playerAnimation;
            while (Narrator.Enemy.HP.CurrentHP > 0)
            {
                //Enemy Attack
                enemyAnimation = Narrator.Enemy.GetAttack(TurnCount, out enemyAttack, out enemyDamage);
                // call narrator to play the animation
                
                if (enemyDamage != 0)
                {
                    if (enemyAttack >= Player.ArmorClass)
                    {
                        Player.HP.ChangeHP(-enemyDamage);
                        // call narrator to display any changes to hp and describe the hit
                    }
                    else
                    {
                        //call narrator to describe the miss
                    }
                }

                //Player Action

                // Call the narrator to prompt which action the player would like to do.
                // Split if statements to abilities, attacks, and items


                //if (playerDamage != 0)
                //{
                //    if (playerAttack >= Narrator.Enemy.ArmorClass)
                //    {
                //        Player.HP.ChangeHP(-enemyDamage);
                //        // call narrator to display any changes to hp and describe the hit
                //    }
                //    else
                //    {
                //        //call narrator to describe the miss
                //    }
                //}

                //End of round cleanup
                foreach (Attack attack in Narrator.AttackList)
                {
                    if (attack.Cooldown != 0)
                    {
                        attack.Cooldown--;
                    }
                }
                TurnCount++;
            }

            return Narrator.Enemy.Exp;
        }

        public override Scene RunScene()
        {
            RunBattle();

            return null;
        }

        public void ProcessMainBattleMenu(int response)
        {
            if (response == 1)
            {

            }
            else if (response == 2)
            {

            }
            else if (response == 3)
            {

            }
            else 
            {
                //Narrator.DisplayHelpMenu();
                Narrator.DisplayMainBattleMenu();
            }
        }
    }
}
