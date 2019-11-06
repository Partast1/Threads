using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheEggClock
{
    class ATMMessages
    {
        public void InsertMessage()
        {
            Console.WriteLine("Please wait");
            //Thread.Sleep(2000);
            
        }
        public void PromptMessage()
        {
            Console.WriteLine("Enter pin code...");
        }
    }
}
