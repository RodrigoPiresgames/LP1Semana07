using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;
 
        public string Name {get;}

        public Player(string name)
        {
            Name = name;
            health = MaxHealth;
            xp = 0;
        }

        public int XP
        {
            get => xp;
            set
            {
                if (XPCheck(value))
                    xp = xp + value;
            }
        }

        public int Level => 1 + (XP / 1000);
        public float MaxHealth => 100 + (Level - 1) * 20;

        public float Health
        {
            get => health;
            set
            {
                if (value <= 0 )
                    health = 0;
                else if ( value > MaxHealth)
                    health = MaxHealth;
                else
                    health = value;
            }
        }

        public void TakeDamage (float damage)
        {
            this.Health = Health - damage;
            this.XP = (int)damage / 20;
        }

        private bool XPCheck(int newXP)
        {
            if (newXP < XP)
                return false;
            else
                return true;
        }

    }
 }