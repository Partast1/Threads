using System;
using System.Collections.Generic;
using System.Text;

namespace Battle
{
    public class Wizard : IFighter
    {
        private int damage;
        private int health;


        private double defend = 20;
        private bool portalOpen = false;
        private Random r = new Random();

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

        int IFighter.DefenseLeft => throw new NotImplementedException();

        public Wizard(int chealth)
        {

            this.health = chealth;

        }


        public int CastFireballSpell()
        {
            return r.Next(10);
        }

        public void Shield(int hits)
        {
            // der kastes et shield som tager noget af slaget
            Random r = new Random();
            int protection = r.Next(100);

            // et shield kan beskytte 0-100%
            defend -= (protection / 100) * defend;
            // Der 29% chance for at en Wizard bliver bange
            if (r.Next(29) <= 5)
            {
                portalOpen = true;
            }

        }

        public bool IsPortalOpened()
        {
            return portalOpen;
        }

        public int DefenseLeft()
        {
            return (int)Math.Round(defend);
        }

        public void Defend(int attack)
        {
            throw new NotImplementedException();
        }

        public bool HasEscaped()
        {
            throw new NotImplementedException();
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }
       
    }
}
