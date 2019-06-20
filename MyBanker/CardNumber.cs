using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class CardNumber
    {
        public string CreateCNumber(int numLeng)
        {
            //List for temporary cardnumber
            List<int> tempCardN = new List<int>();

            Random rnd = new Random();
            //Randomly generates 19 numbers between 1-9
            for (int i = 0; i < numLeng; i++)
            {
                tempCardN.Add((rnd.Next(1, 10)));
            }
            //List is sent to method and returned as int
             string tempnumber;
            //string cardNumbers = CardNumberGenerator(tempCardN);
            tempnumber = string.Join("", tempCardN.ToArray());

            //Serialnumber returned
            //string cardNumber = Convert.ToString(cardNumbers);
            return tempnumber;
        }
    }
}

