using System;
using System.Collections.Generic;
using System.Text;

namespace Vito
{
    public abstract class Pizza
    {
        
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<string> Ingredients;

        public Pizza(string name, List<string> ingredients)
        {
            this.Name = name;
            this.Ingredients = ingredients;
        }

    }
}
