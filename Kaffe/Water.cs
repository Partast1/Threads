using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffe
{
    class Water
    {
        private int liquid;

        public int Liquid
        {
            get { return liquid; }
            set { liquid = value; }
        }
        public Water(int cliquid)
        {
            this.liquid = cliquid;
        }
    }
}
