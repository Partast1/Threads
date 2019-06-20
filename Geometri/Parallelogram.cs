using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Parallelogram : Square
    {
        private Double b;

        public Double B
        {
            get { return b; }
            set { b = value; }
        }

        public Parallelogram(double cside, double cb) : base(cside)
        {
            this.b = cb;

        }
        public Double Arealpara()
        {
             double areala = Side;
            double arealb = b;
            areala = areala * arealb * Math.Sin(20);
            //Console.WriteLine(areala);

            return areala;

        }

    }
}
