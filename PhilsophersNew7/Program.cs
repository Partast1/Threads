using System;
using System.Threading;

namespace PhilsophersNew7
{
    class Program
    {
        object fork1 = new object();
        object fork2 = new object();
        object fork3 = new object();
        object fork4 = new object();
        object fork5 = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                
            }
            Thread p1 = new Thread(new ThreadStart(Phils));

        }
        public static void Phils()
        {

        }
    }
}
