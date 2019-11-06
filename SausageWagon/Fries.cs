using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class Fries : Ingredient, IExpireable, IPrepable
    {
        public Fries(string name, int expir, int prep) : base(name)
        {
            ExpirationTime = expir;
        }

        public int ExpirationTime { get; set; }
        public int PrepTime { get; set; }
    }
}
