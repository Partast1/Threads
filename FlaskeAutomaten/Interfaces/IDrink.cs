using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    public interface IDrink
    {
        string Name { get; set; }
        string Type { get; set; }
        byte Volume { get; set; }
        int Serial { get; set; }

        //Change serialnumber datatype...
    }
}
