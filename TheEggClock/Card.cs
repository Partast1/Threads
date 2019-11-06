using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEggClock
{
   public class Card
    {
        private int pin;
        private double balance;


        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }



        public Card(int pin, double bal)
        {
            Pin = pin;
            Balance = bal;

        }

    }
}
