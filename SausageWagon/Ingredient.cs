using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class Ingredient
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
