using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public class HealthPoints
    {
        public int MaxHP { get; set; }

        public int currentHP;

        public int CurrentHP
        {
            get
            {
                return currentHP;
            }
            set
            {
                if (value > MaxHP)
                {
                    currentHP = MaxHP;
                }
                else
                {
                    currentHP = value;
                }
            } 
        }

        public string HPBar
        {
            get
            {
                string hp = $"{CurrentHP}/{MaxHP} [";
                for (int i = 0; i < CurrentHP; i++)
                {
                    hp = hp + "|";
                }
                hp = hp + $"]";
                return hp;
            }
        }

        public int ChangeHP(int amount)
        {

            return CurrentHP + amount;
        }

        public HealthPoints(int maxHp)
        {
            MaxHP = maxHp;
            CurrentHP = maxHp;
        }
    }
}
