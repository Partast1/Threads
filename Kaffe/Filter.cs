using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffe
{
    public class Filter
    {
        private int filters;

        public int Filters
        {
            get { return filters; }
            set { filters = value; }
        }
        public Filter(int cfilter)
        {
            this.filters = cfilter;
        }

    }
}
