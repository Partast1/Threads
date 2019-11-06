using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SausageWagon2
{
    class Fryer
    {
        private static Queue<Fry> fryBuffer = new Queue<Fry>();

        public static Queue<Fry> FryBuffer
        {
            get { return fryBuffer; }
            set { fryBuffer = value; }
        }

        static byte fryLimit = 2;

        //Check methods in the workstaion classes: makes sure that there are ingredients ready
        public static void Check()
        {
            if (FryBuffer.Count == 0)
            {
                for (int i = 0; i < fryLimit; i++)
                {
                    lock (FryBuffer)
                    {
                        FryBuffer.Enqueue((Fry)IngredientFactory.CreateFries());
                    }

                }
                Console.WriteLine("Putting fries in fryer {0}", FryBuffer.Count + " " + "fries was put in fryer ");
                Thread.Sleep(3000);
            }

        }

        //Remove methods in the workstaion classes: checkes if there is available ingredients and then removes them.
        public static Fry Remove()
        {
            Check();
            Console.WriteLine("Take sausage from grill");
            Fry fry = FryBuffer.Dequeue();
            return fry;
        }

    }
}
