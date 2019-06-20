using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Square
    {
        private Double side;

        public Double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Square(Double cside)
        {
            this.side = cside;
        }
        public Double Omkreds()
        {
            Double omkreds = side;
            side = 4 * side;
            return side;
        }
        public Double Areal()
        {
            Double areal = side;
            side = Math.Pow(side, 2);
            return side;
        }

    }
}
