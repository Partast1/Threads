using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Master : Credit
    {


        private int moneyDaily;

        public int MoneyDaily
        {
            get { return moneyDaily; }
            set { moneyDaily = value; }
        }


        public Master(string cfirstName, string clastName, string ccardNumber, DateTime cexpir, string cAccount, int cmaximum, int cstore, int cMoney) : base(cfirstName, clastName, ccardNumber, cexpir, cAccount, cmaximum, cstore)
        {
            this.moneyDaily = cMoney;
            

        }
    }
}
