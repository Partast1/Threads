using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEggClock
{
    public class AccountMessages
    {
        public void AccountInsuffiant()
        {
            Console.WriteLine("Insuffiant funds");
        }
        public void BalanceCheck(Card card)
        {
            Console.WriteLine("New balance: {0}", card.Balance);
        }
    }
}
