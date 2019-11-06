using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEggClock
{
    class ValidationMessages
    {
        // There methods are used in the 'Validator class'
        public void ApprovedMessage()
        {
            Console.WriteLine("Approved");
        }
        public void DeclinedMessage()
        {
            Console.WriteLine("PIN code wrong, try again");
        }
        public void BlockMessage()
        {
            Console.WriteLine("Card have been blocked...");
        }
    }
}
