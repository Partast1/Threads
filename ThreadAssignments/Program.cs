using System;
using System.Threading;

namespace Daffy
{
    class Program
    {
        #region Opgave 1
        //WorkThreadfunc udskriver simple Thread 5 gange. 
        //Opgave 1
        //public void WorkThread()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        try
        //        {
        //            Console.WriteLine("c# threading er nemt!");
        //            Thread.Sleep(150);
        //        }
        //        catch (Exception ex)
        //        {

        //            Console.WriteLine("Fejl {0}", ex);
        //        }

        //    }

        //}
        #endregion

        #region Opgave 2
        ////Method Assignmen2 writes from another thread this the first is going.
        ////Opgave 2
        //public void Assignmen2()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Også med flere tråde");
        //        Thread.Sleep(150);
        //    }

        //}
        #endregion
        #region Opgave 3
        //public void Assignment3()
        //{
        //    int alarmcount = 0;
        //    Random r = new Random();

        //    while (alarmcount < 3)
        //    {
        //        int ranNumb = r.Next(-20, 120);
        //        Thread.Sleep(2000);
        //        Console.WriteLine("{0} C", ranNumb);
        //        if (ranNumb < 0 || ranNumb > 100)
        //        {
        //            try
        //            {
        //                Console.WriteLine("It is not pleasent to go outside");
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine("Error: " + ex.Message);
        //            }

        //            alarmcount++;
        //        }
        //    }

        //}

        #endregion
        #region Assignment 4
        char ch = '*';
        //Method PrintedThread keeps printing out the char out.
        public void PrintedThread()
        {
            //boolean to keep printing
            bool keepPrinting = true;
            while (keepPrinting == true)
            {
                Console.Write(ch);
                Thread.Sleep(50);
            }
        }
        // RenderThread waits for a userinpput
        public void ReaderThread()
        {
            try
            {
                while (true)
                {
                    char userInput = Convert.ToChar(Console.ReadLine());
                    ch = userInput;
                }
            }
            // Formatexception informs the user that a single char is required
            catch (FormatException)
            {
                //throw new Exception("Skal være et tegn", e);
                Console.WriteLine("Skal være et tegn");
            }
         

        }
        #endregion
    }

    class Threading
    {
        public static void Main()
        {
            bool tempcheck = true;
            //new instance of the program is created
            Program pg = new Program();

            // a new thread is created which takes the method workthread throught the parameters
            //Thread thread1 = new Thread(new ThreadStart(pg.WorkThread));

            //// a new thread is created which takes the method Assignmen2 throught the parameters
            //Thread thread2 = new Thread(new ThreadStart(pg.Assignmen2));

            //// a new thread is created which takes the method Assignmen3 throught the parameters
            //Thread thread3 = new Thread(new ThreadStart(pg.Assignmen3));

            //Input Threads
            Thread threadprint = new Thread(new ThreadStart(pg.PrintedThread));
            Thread threadRead = new Thread(new ThreadStart(pg.ReaderThread));


            //Starting threads

            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            threadprint.Start();
            threadRead.Start();

            //Thread joins
            threadRead.Join();

            //Thread prioit
            //thread1.Priority = ThreadPriority.Lowest;
            //thread2.Priority = ThreadPriority.BelowNormal;
            //thread3.Priority = ThreadPriority.Normal;
            //threadprint.Priority = ThreadPriority.AboveNormal;
            //threadRead.Priority = ThreadPriority.Highest;

            
            //while (tempcheck == true)
            //{
            //    if (!thread3.IsAlive)
            //    {
            //        tempcheck = false;
            //        Console.WriteLine("tempcheck ded");
            //    }
            //    Thread.Sleep(10000);

            //}




            //console read prevents the program from closing after runtime.
            Console.Read();

        }
    }
}

