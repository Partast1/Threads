using System;

namespace Geometri
{
    class Program
    {
        //Create static Double for userinput.
        public static Double inputa;
        public static Double inputb;
        public static Double resultb;
        static void Main(string[] args)
        {
            int test1 = 3;
            int test2 = 5;
            int test3 = 6;
            //int switchInput = 0;

            //inputa = Convert.ToDouble(Console.ReadLine());
            //inputb = Convert.ToDouble(Console.ReadLine());

            Parallelogram pg = new Parallelogram(test1, test2);
            resultb = pg.Arealpara();
            Console.WriteLine(resultb);


            Console.WriteLine();
            
            //switchInput = Convert.ToInt32(Console.ReadLine());
            //switchInput = Convert.ToInt32(Console.ReadLine());

            //User input

            Square sqe = new Square(inputa);
            ////input is sent to Omkreds
            inputa = sqe.Omkreds();
            //Console.WriteLine(inputa);
            ////Console.WriteLine("");
            //switch (switchInput)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;

            //}
            Console.ReadLine();
        }
    }
}


