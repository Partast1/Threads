using System;
using System.Threading;

namespace Coffee
{
    public class Program
    {
        static void Main(string[] args)
        {
            FillWater fw = new FillWater();
            StandardMessage sm = new StandardMessage();
            sm.WelcomeMessage();
            sm.WaterMessage();
            int inputw = Convert.ToInt32(Console.ReadLine());
            fw.WaterToMachine(inputw);
            sm.FilterDiscard();
            Thread.Sleep(1000);
            sm.FilterNew();
            Thread.Sleep(500);
            int inputc = Convert.ToInt32(Console.ReadLine());
            fw.WaterToMachine(inputc);

            Console.ReadLine();
        }

    }
}
