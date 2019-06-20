using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadDayTwo
{
    class Program
    {
        #region Assignment 0

        //Method TaskOne write to the console, everytime the for loop looped
        public void TaskOne(object obj)
        {
            bool isalive = Thread.CurrentThread.IsAlive;
            bool isback = Thread.CurrentThread.IsBackground;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("TaskOne successfully");
            }
        }
        //Method TaskTwo write to the console, everytime the for loop looped
        public void TaskTwo(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("TaskTwo successfully");
            }
        }
        #endregion
        #region Assignment 1
        // This method uses the threadpool to calculate.
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }

        // This method uses only one thread to calculate.
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
                obj.Priority = ThreadPriority.Highest;


            }
        }
        static void Process(object callback)
        {

            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            //Stopwatch to measure the time spent calculating.
            Stopwatch mywatch = new Stopwatch();

            Console.WriteLine("Thread Pool Execution");
            mywatch.Start();

            //ProcessWithThreadPoolMethod();

            mywatch.Stop();
            ProcessWithThreadPoolMethod();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
            mywatch.Reset();
            Console.WriteLine("Thread Execution");
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());

            //Assignment 0
            Program tpd = new Program();
            for (int i = 0; i <= 2; i++)
            {
                ThreadPool.QueueUserWorkItem(tpd.TaskOne);
                ThreadPool.QueueUserWorkItem(tpd.TaskTwo);
            }

            ThreadPool.QueueUserWorkItem(Process);
            Console.Read();
        }


    }
}
