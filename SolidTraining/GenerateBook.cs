using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SolidTraining
{
    public class GenerateBook
    {
        private Book[] books;
        Thread thr;

        public Book[] Books { get => books; set => books = value; }



        public GenerateBook()
        {
            thr = new Thread(ThreadStart)
            {
                Name = "Stram kurs",
                Priority = ThreadPriority.AboveNormal
            };
            thr.Start();
         }

        public void ThreadStart()
        {
            Console.WriteLine("Thread {0} has been started", Thread.CurrentThread.Name);
            ThreadRun();
        }
        public void ThreadRun()
        {
            while (true)
            {
                Thread.Sleep(1000);

            }
        }
    }
}




