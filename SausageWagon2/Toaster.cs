using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SausageWagon2
{
    class Toaster
    {

        private static Queue<Bread> toastBuffer = new Queue<Bread>();

        public static Queue<Bread> ToastBuffer
        {
            get { return toastBuffer; }
            set { toastBuffer = value; }
        }
        static byte toastLimit = 1;

        //Check methods in the workstaion classes: makes sure that there are ingredients ready
        public static void Check()
        {
            if (ToastBuffer.Count == 0)
            {
              
                //ToastBuffer.Enqueue( (Bread) IngredientFactory.CreateBread());
                Thread.Sleep(500);
                Console.WriteLine("Make new Bread");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Der er ingen brød");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        //Remove methods in the workstaion classes: checkes if there is available ingredients and then removes them.
        public static Bread Remove()
        {

            Check();
            Console.WriteLine("Take bread of toaster");
            if (ToastBuffer.Count > 0)
            {
                Bread bread = ToastBuffer.Dequeue();
                return bread;
            }
            return null;
         

        }

    }
}
