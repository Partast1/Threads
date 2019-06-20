using System;
using System.Threading;

namespace SyncDayTwo
{
    class Program
    {

        //Starting counter
        public int counter;
        //Object 'zeKey' is created for enter & exit purposes
        object zeKey = new object();
        
        //Method CounterAdd 
       public void CounterAdd()
        {
            while (true)
            {
                //This try uses 'zeKey' to enter monitor and add to the counter
                try
                {
                    Monitor.Enter(zeKey);
                    counter = counter + 2;
                    Console.WriteLine(counter);
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Something went wrong {0}", ex);
                }
                //Finally will make sure that the monitor can't accidently lock.
                finally
                {
                    Monitor.Exit(zeKey);
                }
               
            }
        }
        void CounterMinus()
        {
            while (true)
            {
                //This try uses 'zeKey' to enter monitor and subtract from the counter
                try
                {
                    Monitor.Enter(zeKey);
                    counter--;
                    Console.WriteLine(counter);
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong {0}", ex);
                }
                //Finally will make sure that the monitor can't accidently lock.
                finally
                {
                    Monitor.Exit(zeKey);
                }
               
            }
        }
        static void Main(string[] args) 
        {
            // New instance of program
            Program pg = new Program();

            //Thread is created. methood Counteradd is added
            Thread threadCount = new Thread(new ThreadStart(pg.CounterAdd));
            try
            {
                threadCount.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //Thread is created. methood CounterMinus is added
            Thread threadCountDown = new Thread(new ThreadStart(pg.CounterMinus));
            try
            {
                threadCountDown.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            threadCount.Join();


            Console.Read();
        }
    }
}
