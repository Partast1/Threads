using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    public class Producer
    {
        static Random rnd = new Random();
        static Factory fc = new Factory();


        public void CreateProducts()
        {
            Buffer buf = new Buffer();

            int rndDrink = rnd.Next(0, 1);
            if (rndDrink == 0)
            {
                    Thread.Sleep(100);
                    buf.BufferReceiver(fc.CreateBeer());
            }
            else
            {
                    Thread.Sleep(100);
                    buf.BufferReceiver(fc.CreateSoda());
            }
        }
    }

}
