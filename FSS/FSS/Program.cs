using System;

namespace FSS
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt");
        }
    }
}
