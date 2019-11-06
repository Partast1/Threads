using System;
using System.Collections.Generic;
using System.Text;

namespace SausageWagon2
{
    class Customer
    {

        public static void Consume(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kunde har modtaget {0}", str);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
