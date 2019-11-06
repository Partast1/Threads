using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class SausageBread : Ingredient, IExpireable, IPrepable
    {
        public int ExpirationTime { get; set; }
        public int PrepTime { get; set; }

        public SausageBread(string name, int expir, int prep) : base(name)
        {
            ExpirationTime = expir;
            PrepTime = prep;
        }
    }
}
