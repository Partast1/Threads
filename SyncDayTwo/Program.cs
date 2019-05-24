using System;
using System.Threading;

namespace SyncDayTwo
{
    class Program
    {
        public int counter;
        object zeKey = new object();
        

       public void CounterAdd()
        {
            while (true)
            {
                Monitor.Enter(zeKey);
                counter = counter + 2;
                Console.WriteLine(counter);
                Thread.Sleep(1000);
                Monitor.Exit(zeKey);
            }
        }
        void CounterMinus()
        {
            while (true)
            {
                Monitor.Enter(zeKey);
                counter--;
                Console.WriteLine(counter);
                Thread.Sleep(1000);
                Monitor.Exit(zeKey);
            }
        }
        static void Main(string[] args) 
        {
            Program pg = new Program();
            Thread threadCount = new Thread(new ThreadStart(pg.CounterAdd));
            threadCount.Start();

            Thread threadCountDown = new Thread(new ThreadStart(pg.CounterMinus));
            threadCountDown.Start();
            threadCount.Join();


            Console.Read();
        }
    }
}
