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
        private readonly float MaxHealth;
 
        public string Name {get;}

        public Player(string name)
        {
            Name = name;
            health = MaxHealth;
        }

        public int XP
        {
            get => xp;
            set => xp = value;
        }

        public int Level => 1 + (XP / 1000);

        public float Health
        {
            get => health;
            set
            {
                if (value <= 0 )
                    health = 0;
                else if ( value >= MaxHealth)
                    health = MaxHealth;
                else
                    health = value
            }
        }
        
    }
 }