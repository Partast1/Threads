using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SausageWagon2
{
    class Grill
    {
        private static Queue<Sausage> sausageBuffer = new Queue<Sausage>();
        private static Queue<Beef> beefBuffer = new Queue<Beef>();
        public static Queue<Sausage> SausageBuffer
        {
            get { return sausageBuffer; }
            set { sausageBuffer = value; }
        }
        public static Queue<Beef> BeefBuffer
        {
            get { return beefBuffer; }
            set { beefBuffer = value; }
        }

        static byte grillLimit = 28;
        static byte beefLimit = 1;

        //Check methods in the workstaion classes, makes sure that there are ingredients ready
        public static void CheckSausage()
        {
            if (SausageBuffer.Count == 0)
            {
                for (int i = 0; i < grillLimit; i++)
                {
                    lock (SausageBuffer)
                    {
                        SausageBuffer.Enqueue( (Sausage) IngredientFactory.CreateSausage());
                    }
                }
                Console.WriteLine("Putting sausage on grill {0}", SausageBuffer.Count + " " + "Sausages was placed on grill ");
                Thread.Sleep(3000);
            }
        }

        //Check methods in the workstaion classes: makes sure that there are ingredients ready
        public static void CheckBeef()
        {
            if (BeefBuffer.Count == 0)
            {
                for (int i = 0; i < beefLimit; i++)
                {
                    lock (BeefBuffer)
                    {
                        BeefBuffer.Enqueue((Beef)IngredientFactory.CreateBeef());
                    }
                }
                Console.WriteLine("Putting beef on grill {0}", BeefBuffer.Count + " " + "beef was placed on grill ");
                Thread.Sleep(3000);
            }
        }

        //Remove methods in the workstaion classes: checkes if there is available ingredients and then removes them.
        public static Beef RemoveBeef()
        {
            CheckBeef();
            Console.WriteLine("Take beef from grill");
            Beef beef = BeefBuffer.Dequeue();
            return beef;
        }

        //Remove methods in the workstaion classes: checkes if there is available ingredients and then removes them.
        public static Sausage RemoveSausage()
        {
            CheckSausage();
            Console.WriteLine("Take sausage from grill");
            Sausage sausage = SausageBuffer.Dequeue();
            return sausage;
        }

    }
}
