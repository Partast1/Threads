using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEggClock
{
    public class ATM
    {
        Validator val = new Validator();
        //Takes a card
        public void InsertCard(Card card)
        {
            ATMMessages atmm = new ATMMessages();

            atmm.InsertMessage();
            
                Convert.ToInt32( card.Pin);
            PromptPIN(card);
        }
        // Prompts the user for their PIN code
        public void PromptPIN(Card card)
        {
            ATMMessages atmm = new ATMMessages();
            int value;
            atmm.PromptMessage();
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
              
                val.ValidateAccount(card, input);

            }
            catch (FormatException e)

            {

                throw new Exception("Wrong input", e); 
            }
            finally
            {
                PromptPIN(card);
            }
            
        }

        // Opens the possibility for withdrawal
        public void FrontScreen(Card card)
        {
            Account account = new Account();

            Console.WriteLine("Balance is {0}",card.Balance);
            Console.WriteLine("Press 1 for Withdrawl");
            int userinput =  Convert.ToInt32(Console.ReadLine());
            
            switch (userinput)
            {
                
                case 1:
                    Console.WriteLine("Select amount to withdraw");
                    double userWithdrawal = Convert.ToDouble(Console.ReadLine());
                    account.BalanceCheck(card, userWithdrawal);
                    break;
                
            }
        }
    }
}
