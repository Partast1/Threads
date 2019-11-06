using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace FlaskeAutomaten
{

    public class Threads
    {
        static object zeKey = new object();

        public Thread ProducerThread;
        public Thread ConsumerThread;
        Producer pro = new Producer();
        public void ThreadStarter()
        {
            ProducerThread = new Thread(pro.CreateProducts)
            {
                Name = "ProductionThread",
                Priority = ThreadPriority.AboveNormal
            };
            Monitor.TryEnter(zeKey);
            {
                ProducerThread.Start();

            }

            ConsumerThread = new Thread(pro.CreateProducts)
            {
                Name = "ConsumerThread",
                Priority = ThreadPriority.Normal
            };
            Monitor.TryEnter(zeKey);
            {
                ConsumerThread.Start();

            }

        }

    }


}
