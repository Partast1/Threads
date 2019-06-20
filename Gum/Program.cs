using System;
using System.Collections.Generic;
using System.Text;

namespace Gum
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Press to get gum");

            //UserDispenser usr = new UserDispenser();
            List<Candy> cand = new List<Candy>();
            UserDispenser usr = new UserDispenser(cand);

            foreach (Candy item in cand)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
