using System;
using System.Collections.Generic;
using System.Text;

namespace Travbane
{
    class Race
    {
        private int participants;
        private string colour;
        private int distance;



        public int Participants
        {
            get { return participants; }
            set { participants = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

    }
}
