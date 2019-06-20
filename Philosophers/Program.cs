using System;
using System.Collections.Generic;
using System.Threading;

namespace Philosophers
{
    public class Program
    {
        public List<Fork> listFirst;
        public List<Fork> listSecond;
        public Fork f1 = new Fork();
        Fork f2 = new Fork();
        Fork f3 = new Fork();
        Fork f4 = new Fork();
        Fork f5 = new Fork();


        object Fork1 = new object();
        object Fork2 = new object();
        object Fork3 = new object();
        object Fork4 = new object();
        object Fork5 = new object();
        

        #region Philosopher 1
        public void PhilosopherOne()
        {
            
            listFirst = new List<Fork>();
            //Each open Monitor works like an if statement
            Monitor.TryEnter(Fork1, 1000);
          
            Console.WriteLine("P1 Fork 1 equipped");
            Thread.Sleep(1000);
            Monitor.TryEnter(Fork5, 1000);

            Console.WriteLine("P1 Fork 5 equipped");
            Thread.Sleep(1000);
            Console.WriteLine("Philosopher 1 Eating...");
            listFirst.Clear();
            Monitor.Exit(Fork1);
            Monitor.Exit(Fork5);
            //try
            //{
            //    Monitor.Enter(zeKey);
            //    bool IsLocked(object o)
            //    {
            //        if (!Monitor.TryEnter(o))
            //            return true;
            //        Monitor.Exit(o);
            //        return false;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
        #endregion
        #region Philosopher 2
        public void PhilosopherTwo()
        {
            //Each open Monitor works like an if statement
            listSecond = new List<Fork>();

            Monitor.TryEnter(Fork2, 1000);
            Console.WriteLine("P2 Fork 2 is equipped");

                Monitor.TryEnter(Fork3, 1000);
                Console.WriteLine("P2 Fork 3 is equipped");
                Console.WriteLine("Philosoph2 Eating...");
            Monitor.Exit(Fork2);
            Monitor.Exit(Fork3);
        }
        public void PhilosopherThree()
        {
            //Each open Monitor works like an if statement
            listSecond = new List<Fork>();

            Monitor.TryEnter(Fork3, 1000);

            Console.WriteLine("P3 Fork 3 is equipped");
            Monitor.TryEnter(Fork4, 1000);

            Console.WriteLine("P3 Fork 4 is equipped");
            Console.WriteLine("Philosoph3 Eating...");
            Monitor.Exit(Fork3);
            Monitor.Exit(Fork4);
        }
        #endregion
        static void
        Main(string[] args)
        {
            Program pg = new Program();
            //ThreadPool.QueueUserWorkItem(pg.PhilosopherOne));
            Thread philosopherOne = new Thread(new ThreadStart(pg.PhilosopherOne));
            Thread philosopherTwo = new Thread(new ThreadStart(pg.PhilosopherTwo));



            philosopherOne.Start();
                philosopherOne.Priority = ThreadPriority.Highest;
            philosopherTwo.Start();
            philosopherTwo.Join();

            Console.ReadLine();
            
        }
    }
}
