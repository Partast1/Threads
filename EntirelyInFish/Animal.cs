using System;
using System.Collections.Generic;
using System.Text;

namespace EntirelyInFish
{
    class Animal
    {
        private string name;
        private string length;
        private string height;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Length

        {
            get { return length; }
            set { length = value; }
        }

        public string Height

        {
            get { return height; }
            set { height = value; }
        }
        public Animal(string cname, string clength, string cheight)
        {
            this.name = cname;
            this.length = clength;
            this.height = cheight;
        }
        public Animal()
        {

        }

    }
}
