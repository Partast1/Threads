using System;
using System.Collections.Generic;
using System.Text;

namespace Space
{
    public class UFO : EnemyShip
    {
        public UFO(string name, byte hitpoints, int attackRange)
         : base(name, hitpoints, attackRange)
        {

        }
    }
}
