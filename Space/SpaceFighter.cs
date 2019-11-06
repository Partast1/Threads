using System;
using System.Collections.Generic;
using System.Text;

namespace Space
{
    public class SpaceFighter : EnemyShip
    {
        byte warpSpeed;

        public SpaceFighter(string name, byte hitpoints, int attackRange, byte warpSpeed)
         : base(name, hitpoints, attackRange)
        {
            WarpSpeed = warpSpeed;
        }

        public byte WarpSpeed { get => warpSpeed; set => warpSpeed = value; }
    }

}
