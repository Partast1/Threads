using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEggClock
{
    public class Account
    {
      

        //Subtracts the wanted amount from the current Balance
        public void Withdrawal(Card card, double wantedAmount)
        {
           
                card.Balance = card.Balance - wantedAmount;




        }
        //Checks if the current Balance is greater than the wanted amount
        public bool BalanceCheck(Card card, double wantedAmount)
        {
            bool balancebool;
            ATM atm = new ATM();
            AccountMessages accountMessages = new AccountMessages();
            if (wantedAmount <= card.Balance)
            {
                
                Withdrawal(card, wantedAmount);
                accountMessages.BalanceCheck(card);
                return true;
            }
            else 
            {
                accountMessages.AccountInsuffiant();
                atm.FrontScreen(card);
                return false;

            }
        }

    
    }
}
