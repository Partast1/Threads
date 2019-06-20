using System;
using System.Collections.Generic;
using System.Threading;

namespace Philosophers2
{
    public class Program
    {
        // Objects are used as forks 
        object Fork1 = new object();
        object Fork2 = new object();
        object Fork3 = new object();
        object Fork4 = new object();
        object Fork5 = new object();

        #region Philosopher 1
        public void PhilosopherOne(object ob)
        {
            //lock makes sure no other thread can access the same data
            lock (Fork5)
            {
                Console.WriteLine("P1 Fork 5 equipped");
                Thread.Sleep(500);
                lock (Fork1)
                {
                    //If both obejcts can be obtained the Philosopher can eat
                    Console.WriteLine("P1 Fork 1 equipped");
                    Console.WriteLine("Philosopher one eating");
                    Thread.Sleep(500);
                }
            }
        }
        #endregion
        #region Philosopher 2
        public void PhilosopherTwo(object ob)
        {
            //locks object "Fork1"
            lock (Fork1)
            {
                Console.WriteLine("P2 Fork 1 equipped");
                Thread.Sleep(500);
                lock (Fork2)
                {
                    Console.WriteLine("P2 Fork 2 equipped");
                    Console.WriteLine("Philosopher two eating");
                    Thread.Sleep(500);
                }
            }
        }
        #endregion
        #region Philosopher 3
        public void PhilosopherThree(object ob)
        {
            lock (Fork1)
            {
                Console.WriteLine("P3 Fork 3 equipped");
                Thread.Sleep(500);
                lock (Fork2)
                {
                    Console.WriteLine("P3 Fork 4 equipped");
                    Console.WriteLine("Philosopher Three eating");
                    Thread.Sleep(500);
                }
            }
        }
        #endregion
        #region Philosopher 4
        public void PhilosopherFour(object ob)
        {
            lock (Fork1)
            {
                Console.WriteLine("P4 Fork 4 equipped");
                Thread.Sleep(500);
                lock (Fork2)
                {
                    Console.WriteLine("P4 Fork 5 equipped");
                    Console.WriteLine("Philosopher Four eating");
                    Thread.Sleep(500);
                }
            }
        }
        #endregion
        #region Philosopher 5
        public void PhilosopherFive(object ob)
        {
            lock (Fork1)
            {
                Console.WriteLine("P5 Fork 5 equipped");
                Thread.Sleep(500);
                lock (Fork2)
                {
                    Console.WriteLine("P5 Fork 1 equipped");
                    Console.WriteLine("Philosopher Five eating");
                    Thread.Sleep(500);
                }
            }
        }
        #endregion

        static void
        Main(string[] args)
        {
            Program pg = new Program();

            while (true)
            {
                //Threadpool makes sure to managed the threads 
                ThreadPool.QueueUserWorkItem(pg.PhilosopherOne);
                ThreadPool.QueueUserWorkItem(pg.PhilosopherTwo);
                ThreadPool.QueueUserWorkItem(pg.PhilosopherThree);
                ThreadPool.QueueUserWorkItem(pg.PhilosopherFour);
                ThreadPool.QueueUserWorkItem(pg.PhilosopherFive);
            }
        }
    }
}

