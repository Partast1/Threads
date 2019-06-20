using System;
using System.Collections.Generic;
using System.Threading;

namespace Producer
{
    class Program
    {

        public static int itemCount = 0;
        public int maxCount = 8;
        //buffer is represented by a queue
        public static Queue<int> buffer = new Queue<int>();
        //zekey is the object used for locking
        object zekey = new object();
        //Buffer
        static void Main(string[] args)
        {
            Program pg = new Program();
            //Threads are created
            Thread producerThread = new Thread(pg.Producer);
            Thread consumerThread = new Thread(pg.Consumer);
            //Threads started..
            producerThread.Start();
            consumerThread.Start();
            //ThreadPool.QueueUserWorkItem(pg.Producer);
            //ThreadPool.QueueUserWorkItem(pg.Consumer);
            Console.ReadLine();
        }

        public void Producer(object ob)
        {
            while (true)
            {
                
                if (buffer.Count < maxCount)
                {
                    //Producer() locks key
                    lock (zekey)
                    {
                        Console.WriteLine("itemCount {0}",itemCount);
                        CreateProducer();
                        Thread.Sleep(700);
                        Console.WriteLine(buffer.Count);
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                }

            }

    }
        public void Consumer(object ob)
        {
            while (true)
            {
                if (buffer.Count > 0)
                {
                    //Consumer() locks key
                    lock (zekey)
                    {
                        //Console.WriteLine("itemCount {0}", itemCount);

                        Consuming();
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }

        }
        //Method creates 4 produces
        private void CreateProducer()
        {

            for (int i = 0; i < 4; i++)
            {
                buffer.Enqueue(itemCount);
                Console.WriteLine("Producer produced an item {0}", itemCount);
                itemCount++;
            }

        }
        //Consumer removes item if available
        public void Consuming()
        {
            if (buffer.Count > 0)
            {
              
                Console.WriteLine("Consumer Cunsumed an item {0}",buffer.Dequeue());
            }
        }
    }
}
