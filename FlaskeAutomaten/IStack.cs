using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    interface IStack
    {
        Stack<IDrink> Drinks { get; set; }
    }
}
