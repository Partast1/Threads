using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    class Drink : IDrink
    {
        public string Name { get ; set ; }
        public string Type { get ; set ; }
        public byte Volume { get ; set ; }
        public int Serial { get ; set ; }
    }
}
