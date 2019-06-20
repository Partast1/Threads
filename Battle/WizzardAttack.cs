using System;
using System.Collections.Generic;
using System.Text;

namespace Battle
{
    class WizzardAttack : IFighter
    {

        private int defenseLeft;
        public int DefenseLeft{ get; }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public void Defend(int attack)
        {
            throw new NotImplementedException();
        }

        public bool HasEscaped()
        {
            throw new NotImplementedException();
        }
        public
    }
}
