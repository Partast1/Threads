using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
   public class Credit : CreditCard
    {
        private int maximumPerMonth;
        private int storeCredit;
        public int MaximumPerMonth
        {
            get { return maximumPerMonth; }
            set { maximumPerMonth = value; }
        }
        public int StoreCredit
        {
            get { return storeCredit; }
            set { storeCredit = value; }
        }
        public Credit(string cfirstName, string clastName, string ccardNumber, DateTime cexpir, string cAccount,int cmaximum, int cstore) :base(cfirstName, clastName, ccardNumber,cexpir,cAccount)
        {
            this.maximumPerMonth = cmaximum;
            this.storeCredit = cstore;
        }
    }
}
