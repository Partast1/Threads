using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee
{
   public class FillWater
    {

        StandardMessage sm = new StandardMessage();

        public void WaterToMachine(int cup)
        {
            
            if (cup <= 10 && cup >= 1)
            {
                sm.WaterSuccessfullyFilled(cup);
            }
            else
            {
                sm.WaterErrorMessage();
            }
        }
    }
}
