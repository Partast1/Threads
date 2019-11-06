using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEggClock
{
    public class Validator
    {
        static int validatorCount = 0;
        public bool validatorBool = true;

        // Validates that the pin code is valid
        public void ValidateAccount(Card card, int input)
        {

            ATM atm = new ATM();

            ValidationMessages vm = new ValidationMessages();

            while (validatorBool)
            {
                if (validatorCount <= 1)
                {
                    if (input == card.Pin)
                    {
                        vm.ApprovedMessage();
                        validatorBool = false;
                        atm.FrontScreen(card);
                    }
                    else
                    {

                        validatorCount++;
                        validatorBool = true;
                        vm.DeclinedMessage();
                        atm.PromptPIN(card);

                    }

                }
                else
                {
                  
                    vm.BlockMessage();
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
    }
}
