using System;
using System.Collections.Generic;
using System.Text;

namespace Gum
{
    public class CreateCandy
    {
        public List<Candy> CreateGum()
        {
            //List for all the variables 
            List<Candy> Candies = new List<Candy>();
            Random r = new Random();
            int rNumber = 0;
            //Creates 55 new gum
            for (int i = 0; i < 55; i++)
            {
                rNumber = r.Next(0, 100);

                if (rNumber <= 25)
                {
                    Candy bb = new Candy("Blueberry");
                    Candies.Add(bb);
                }
                else if (rNumber <= 25 + 12)
                {
                    Candy bby = new Candy("Blackberry");
                    Candies.Add(bby);
                }
                else if (rNumber <= 25 + 32)
                {
                    Candy tt = new Candy("Tutti");
                    Candies.Add(tt);
                }
                else if (rNumber <= 25 + 51)
                {
                    Candy oag = new Candy("Orange");
                    Candies.Add(oag);
                }
                else if (rNumber <= 25 + 65)
                {
                    Candy sb = new Candy("Strawberry");
                    Candies.Add(sb);

                }
                else if (rNumber <= 25 + 75)
                {
                    Candy ap = new Candy("Apple");
                    Candies.Add(ap);

                }
            }


            return Candies;

        }
    }
}



