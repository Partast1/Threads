using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class BurgerBun : Ingredient, IExpireable, IPrepable
    {
        public int ExpirationTime { get; set; }
        public int PrepTime { get; set; }

        public BurgerBun(string name, int expir, int prep) : base(name)
        {
            ExpirationTime = expir;
            PrepTime = prep;
        }
    }
}
