using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class Producer
    {
       
        Buffer buf = new Buffer();

        public List<Ingredient> preps = new List<Ingredient>();

        public void NewOrder(Ingredient prep)
        {
            if (prep is IPrepable)
            {
                IPrepable ing = (IPrepable)prep;
                Thread.Sleep(ing.PrepTime);

            }
            Console.WriteLine("{0} er nu i produktion", prep.Name);

            preps.Add(prep);
        }
        public void Production() 
        {
            foreach (Ingredient item in preps)
            {
                Console.WriteLine(preps.Count);
                buf.Produce(item);
                
                preps.Remove(item);

            }
        }


    }
}
