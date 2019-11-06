using System;

namespace EventNU2
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer pro = new Producer();
            pro.ProducerRequestEvent += OnProducerRequestEvent;

        }
        private static void OnProducerRequestEvent(object sender, Log message)
        {
            Console.WriteLine("MainThread log " + message.Message);
        }
    }
}
