using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public class Maestro : Debit, IAgeRequirement
    {
        public int requiredAge { get; set; }
        
        public Maestro(string cfirstName, string clastName, string ccardNumber, DateTime cexpir, string cAccount, int cRequiredAge) : base(cfirstName, clastName, ccardNumber, cexpir, cAccount)
        {
            this.requiredAge = cRequiredAge;

        }
    }
}
