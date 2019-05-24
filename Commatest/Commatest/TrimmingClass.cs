using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commatest
{
   public class TrimmingClass
    {
         public string Trimming(string Untrimmed)
        {

            string unTrimmedString = Untrimmed;
            string Trimmed = unTrimmedString.Replace(",", "").Replace(".", "").Trim().ToLower();
            return Trimmed;


        }
    }
}
