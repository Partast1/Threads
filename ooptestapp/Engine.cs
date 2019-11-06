using System;
using System.Collections.Generic;
using System.Text;

namespace ooptestapp
{
    class Engine
    {
        // Attributes
        private int horsePower;
        private int cylinder;

        // Properties
        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public int Cylinder
        {
            get { return cylinder; }
            set { cylinder = value; }
        }
        public Engine(int hp, int cyl)
        {
            hp = HorsePower;
            cyl = Cylinder;
        }

    }
}
