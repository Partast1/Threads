using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    public class ConsumerSplitter
    {
        static Stack<IDrink> Sodas = new Stack<IDrink>();
        static Stack<IDrink> Beers = new Stack<IDrink>();

        public void SplitterReceiver()
        {
            Buffer buf = new Buffer();
            var drink = buf.BufferSender();
            if (drink.Type == "Beer")
            {
                Beers.Push(drink);
            }
            else
            {
                Sodas.Push(drink);
            }
        }
        public void ConsumerSender()
        {
            Buffer buf = new Buffer();

            Sodas.Pop();
        }
    }
}
