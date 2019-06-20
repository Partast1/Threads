using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public class Visa : Credit, IAgeRequirement
    {
        public int requiredAge { get; set; }
        public Visa(string cfirstName, string clastName, string ccardNumber, DateTime cexpir, string cAccount, int cmaximum, int cstore, int cRequiredAge) : base(cfirstName, clastName, ccardNumber, cexpir, cAccount, cmaximum, cstore)
        {
            this.requiredAge = cRequiredAge;
        }
    }
}
