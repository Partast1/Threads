using System;
using System.Collections.Generic;
using System.Text;

namespace Arkimedes
{
    public class Fork
    {
        private string name;
        public string Name { get; set; }

        public Fork(string cname)
        {
            this.name = cname;
        }
    }
}
