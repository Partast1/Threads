using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class Threads
    {
        public object obj = new object();

        public void ThreadStarter()
        {
            Producer pr = new Producer();
            Consumer con = new Consumer();
            OrderHandler ord = new OrderHandler();

            Thread OrderThread = new Thread(ord.CreateOrder)
            {
                Name = "Customer Thread", // Set Thread Name [ProduceThread]
                Priority = ThreadPriority.Normal, // Set Thread Priority Normal]
                IsBackground = false
            };
            Monitor.TryEnter(obj);
            {
                OrderThread.Start();
                OrderThread.Join();
            }

            Thread produceThread = new Thread(pr.Production)
            {
                Name = "Produce Thread", // Set Thread Name [ProduceThread]
                Priority = ThreadPriority.Normal, // Set Thread Priority Normal]
                IsBackground = false
            };
            Monitor.TryEnter(obj);
            {
                produceThread.Start();
                produceThread.Join();
            }



            Thread consumerThread = new Thread(con.Consume)
            {
                Name = "Consumer Thread", // Set Thread Name [ProduceThread]
                Priority = ThreadPriority.Normal, // Set Thread Priority Normal]
                IsBackground = false
            };
            Monitor.TryEnter(obj);
            {
                consumerThread.Start();
                consumerThread.Join();
            }
        
        }
    }
}
