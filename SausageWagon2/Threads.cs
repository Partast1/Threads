using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SausageWagon2
{
    class Threads
    {
        static Chef chef = new Chef();
        Customer cus = new Customer();


        //public static void ProduceThread()
        //{
        //    Thread ProduceThread = new Thread(Chef.)
        //    {
        //        Name = "Produce Thread", // Set Thread Name [Produce Thread]
        //        Priority = ThreadPriority.Normal, // Set Thread Priority Normal]
        //        IsBackground = false
        //    };
        //    Monitor.TryEnter(chef);
        //    {
        //        ProduceThread.Start();
        //        ProduceThread.Join();
        //    }
        //}
        //public static void ConsumeThread()
        //{
        //    Random rnd = new Random();

        //    Thread ConsumeThread = new Thread(Customer.Consume)
        //    {
        //        Name = "Consume Thread", // Set Thread Name [Consume Thread]
        //        Priority = ThreadPriority.Normal, // Set Thread Priority Normal]
        //        IsBackground = false
        //    };
        //    Monitor.TryEnter(chef);
        //    {
        //        Console.WriteLine("Thread sleeping");
        //        Thread.Sleep(rnd.Next(500, 3000));
        //        Console.WriteLine("Thread started");
        //        ConsumeThread.Start();
        //        ConsumeThread.Join();
        //    }
        //}
    }
}

