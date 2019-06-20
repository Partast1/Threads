using System;
using System.Collections.Generic;
using System.Text;

namespace Travbane
{
    class Horse
    {
        private int number;
        private string colour;
        private int speed;

       

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Horse(int cnumber, int cspeed)
        {
            this.number = cnumber;
            
            this.speed = cspeed;
        }
    }
}
