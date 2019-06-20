using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public class DebitCard : Debit
    {
        public DebitCard(string cfirstName, string clastName, string ccardNumber, DateTime cexpir, string cAccount) : base(cfirstName, clastName, ccardNumber, cexpir, cAccount)
        {
        }
    }
}
