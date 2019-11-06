using System;
using System.Collections.Generic;
using System.Text;

namespace SausageWagon2
{
    class Ingredient
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Ingredient(string name)
        {
            Name = name;
        }

    }
}
