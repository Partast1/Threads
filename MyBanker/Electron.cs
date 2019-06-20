using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public class Electron : Debit, IAgeRequirement
    {
        public int requiredAge { get; set; }

        private int maximumPerMonth;
        public int MaximumPerMonth
        {
            get { return maximumPerMonth; }
            set { maximumPerMonth = value; }
        }
        public Electron(string cfirstName, string clastName, string ccardNumber, DateTime cexpir, string cAccount, int cmax, int cRequiredAge) : base(cfirstName, clastName, ccardNumber, cexpir, cAccount)
        {
            this.maximumPerMonth = cmax;
            this.requiredAge = cRequiredAge;
        }
    }
}
