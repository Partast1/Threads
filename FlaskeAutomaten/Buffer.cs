using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    public class Buffer
    {
        static Stack<IDrink> Drinks = new Stack<IDrink>();

        public void BufferReceiver(IDrink drinks)
        {
            byte maxAmount = 6;
            lock (Drinks)
            {
                if (Drinks.Count <= maxAmount)
                {
                    Drinks.Push(drinks);
                    Console.WriteLine("{0} in buffer", drinks.Name);

                }
                else
                {
                    Console.WriteLine("Buffer fuld");
                }
            }

        }
        public IDrink BufferSender()
        {
           var drink = Drinks.Pop();
            return drink;
        }
    }
}
