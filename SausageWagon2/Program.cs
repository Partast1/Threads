using System;
using System.Threading;

namespace SausageWagon2
{
    class Program
    {
        Threads thr = new Threads();
         static void Main(string[] args)
        {
            //Static oprettelse af Order for debug
            //Order ord = new OrderList.
            //OrderList.Orders.Enqueue(ord);
            Chef chef = new Chef();
            while (true)
            {
                //Threads.ProduceThread();
                //Threads.ConsumeThread();
                OrderHandler order = new OrderHandler();
                Thread OrderThread = new Thread(order.CreateOrder);
                OrderThread.Start();
                Random rnd = new Random();
                Thread.Sleep(rnd.Next(1000, 2000));

            }
        }
    }
}
