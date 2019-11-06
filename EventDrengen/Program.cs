using System;

namespace EventDrengen
{
    class Program
    {
       static Eventtest test = new Eventtest();

        static void Main(string[] args)
        {

            test.Debug += Test_Debug;
            Console.ReadLine();
        }

        private static void Test_Debug(object sender, EventArgs e)
        {
            Console.WriteLine(sender + e.ToString());
        }
    }
}
