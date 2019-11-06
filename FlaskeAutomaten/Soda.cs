using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    public class Soda : IDrink
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public byte Volume { get; set; }
        public int Serial { get; set; }

        public Soda(string name, string type, byte volume, int serial)
        {
            Name = name;
            Type = type;
            Volume = volume;
            Serial = serial;
            
        }
    }
}
