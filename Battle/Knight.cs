using System;
using System.Collections.Generic;
using System.Text;

namespace Battle
{
    public class Knight : IFighter
    {
        private int defenseLeft;
        
        

        public int DefenseLeft
        {
            get { return health; }
        }
        //Denne metode kaldes når fighteren skal forsvare sig
        public void Defend(int attack)
        {
            health = health - attack;
        }
        //return true hvis fighteren stikker af
        public bool HasEscaped()
        {
            Random r = new Random();
            int chance = r.Next(0, 101);

            if (chance <= 5)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        //Denne metode kaldes når fighteren skal angribe
        //og returnere en int værdi med hvor meget han /hun angriber
        public int Attack()
        {
            Random r = new Random();
            Damage = r.Next(1, 7);
            return Damage;
        }
        private int damage;
        private int health;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Knight(int chealth)
        {

            this.health = chealth;

        }





    }
}
