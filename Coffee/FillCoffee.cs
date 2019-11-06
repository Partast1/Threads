using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee
{
   public class FillCoffee
    {
        StandardMessage sm = new StandardMessage();

        public void CoffeeToMachine(int coffee)
        {
            if (coffee > 1 && coffee < 15)
            {
                sm.CoffeeSuccessfullyAdded(coffee);
            }
            else
            {
                sm.CoffeeFailure();
            }
        }
    }
}
