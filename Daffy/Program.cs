using System;
using System.Threading;

namespace Daffy
{
    class Program
    {
        //WorkThreadfunc udskriver simple Thread 5 gange. 
        public void WorkThread()
        {
            for (int i = 0; i < 5; i++)

                Console.WriteLine("c# threading er nemt!");
        }

    }

    class Threading
    {
        public static void Main()
        {
            //new instance of the program is created
            Program pg = new Program();
            // a new thread is created which takes the method workthread throught the parameters
            Thread thread = new Thread(new ThreadStart(pg.WorkThread));
            //The Thread is started
            thread.Start();
            //console read prevents the program from closing after runtime.
            Console.Read();

        }
    }
}

