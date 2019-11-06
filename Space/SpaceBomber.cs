using System;
using System.Collections.Generic;
using System.Text;

namespace Space
{
    public class SpaceBomber : EnemyShip
    {
        int bombSize;

        public SpaceBomber(string name, byte hitpoints, int attackRange, byte bombSize)
           : base(name, hitpoints, attackRange)
        {
            BombSize = bombSize;
        }

        public int BombSize { get => bombSize; set => bombSize = value; }
    }
}
