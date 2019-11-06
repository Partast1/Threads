using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTraining
{
    public class Hero
    {
        private string alias;

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        public Hero()
        {

        }
        public Hero(string ali)
        {
            alias = ali;
        }

    }
}
