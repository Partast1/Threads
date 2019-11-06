using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee
{
    public class StandardMessage
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the coffee maker");
        }
        public void WaterMessage()
        {
            Console.WriteLine("How many cups of water would you like to add?");
            Console.WriteLine("Minimum of 1 cup and a maximum of 10 cups.");
        }
        public void WaterErrorMessage()
        {
            Console.WriteLine("You havn't fulfilled the water request properly.");
        }
        public void WaterSuccessfullyFilled(int cup)
        {

            Console.WriteLine("{0} cups of water have been added", cup);
        }
        public void FilterDiscard()
        {
            Console.WriteLine("Opening machine and disposing of used filter");
            
        }
        public void FilterNew()
        {
            Console.WriteLine("Putting in a new filter");
        }
        public void CoffeeSuccessfullyAdded(int coffee)
        {
            Console.WriteLine("{0} scoops of coffee have been added", coffee);
        }
        public void CoffeeFailure()
        {
            Console.WriteLine("You havn't fulfilled the Coffee request properly.");
        }
        public void ReadyToBrew()
        {
            Console.WriteLine();
        }
    }
}
