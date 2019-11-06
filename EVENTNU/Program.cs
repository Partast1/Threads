using System;

namespace EVENTNU
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola ca = new Cola(32);
            ca.SodaThreadEvent += OnSodaThreadEvent;
        }

        private static void OnSodaThreadEvent(object sender, Log log)
        {
            Console.WriteLine("MainThread log " + log.Message);
        }
    }
}
