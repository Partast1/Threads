using System;

namespace Kaffe
{
    class Program
    {
        public static int waterAmount;
        static void Main(string[] args)
        {
            WaterContainer wc = new WaterContainer();
            int inputWater = Convert.ToInt32(Console.ReadLine());
            Water w = new Water(inputWater);
            waterAmount = wc.FillWater(inputWater);
            Console.WriteLine("Current cups of water {0}",waterAmount);
        }
    }
} 
