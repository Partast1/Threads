using System;
using System.Collections.Generic;
using System.Text;

namespace Gum
{

    public abstract class Dispenser
    {
        
         List<Candy> mixCandy;
        public void CreateDispenser()
        {
            CreateCandy cc = new CreateCandy();
            mixCandy = cc.CreateGum();
        }
        public Dispenser(List<Candy> cmix)
        {
            this.mixCandy = cmix;
        }
    }

    public class UserDispenser : Dispenser
    {
        public void DispenseCandy()
        {
           
        }
        public UserDispenser(List<Candy> cmix) : base(cmix)
        { }
    }

}


