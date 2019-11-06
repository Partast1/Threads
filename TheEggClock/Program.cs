using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEggClock
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            //a
            Card card = new Card(1234, 4752);

            atm.InsertCard(card);

            Console.ReadLine();
        }
    }
}
