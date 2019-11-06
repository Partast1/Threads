using System;
using System.Threading;

namespace Producer_Consumer
{
    public class Program
    {
        public static object zeKey = new object();

        static void Main(string[] args)
        {
            while (true)
            {
                //Creation of new Threads
                Thread productionThread = new Thread(new ThreadStart(Producer.ProduceToBuffer));
                Thread ConsumerThread = new Thread(new ThreadStart(Consumer.ConsumeFromBuffer));

                //Starting new Threads
                productionThread.Start();
                ConsumerThread.Start();
            }
        }
    }
}
