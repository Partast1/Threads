using System;
using System.Collections.Generic;
using System.Text;

namespace Gum
{
    public class Candy
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Candy(string cname)
        {
            this.name = cname;
        }
        public Candy()
        {
            
        }

    }
}
