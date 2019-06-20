using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public class Debit : CreditCard
    {
        public Debit(string cfirstName, string clastName, string ccardNumber, DateTime cexpir, string cAccount) : base(cfirstName, clastName, ccardNumber, cexpir, cAccount)
        {

        }
    }
}
