using System;
using System.Collections.Generic;
using System.Text;

namespace Space
{
    public abstract class EnemyShip
    {
        string name;
        byte hitpoints;
        int attackRange;

        protected EnemyShip(string name, byte hitpoints, int attackRange)
        {
            Name = name;
            Hitpoints = hitpoints;
            AttackRange = attackRange;
        }

        public string Name { get => name; set => name = value; }
        public byte Hitpoints { get => hitpoints; set => hitpoints = value; }
        public int AttackRange { get => attackRange; set => attackRange = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
