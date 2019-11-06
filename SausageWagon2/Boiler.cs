using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SausageWagon2
{
    class Boiler
    {
        private static Queue<Sausage> boilerBuffer = new Queue<Sausage>();


        public static Queue<Sausage> BoilerBuffer
        {
            get { return boilerBuffer; }
            set { boilerBuffer = value; }
        }

        static byte boilerLimit = 60;

        //Check methods in the workstaion classes: makes sure that there are ingredients ready
        public static void Check() 
        {
            if (BoilerBuffer.Count == 0)
            {
                for (int i = 0; i < boilerLimit; i++)
                {
                    lock (BoilerBuffer)
                    {
                        BoilerBuffer.Enqueue( (Sausage) IngredientFactory.CreateSausage());
                    }
                }
                Console.WriteLine("Putting sausage in boiler {0}", BoilerBuffer.Count + " " + "Sausages was placed in boiler ");
                //Thread.Sleep();
            }
        }
        //Remove methods in the workstaion classes: checkes if there is available ingredients and then removes them.
        public static Sausage Remove()
        {
            Check();
            Console.WriteLine("Take sausage from boiler");
            Sausage sausage = BoilerBuffer.Dequeue();
            return sausage;
        }
        
    }
}
