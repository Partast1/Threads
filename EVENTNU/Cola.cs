using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EVENTNU
{
    class Cola
    {
        private int amount;
        Thread thr;

        public delegate void SodaEventHandler(object sender, Log log);
        public event SodaEventHandler SodaThreadEvent;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Cola(int amount)
        {
             thr = new Thread(StartThread)
            {
                Name = "cola",
                Priority = ThreadPriority.AboveNormal
            };
            thr.Start();
            Amount = amount;
        }

        private void StartThread()
        {
            Console.WriteLine("Starting thread");

            ThreadRun();
        }

        private void ThreadRun()
        {
            while (true)
            {
                Thread.Sleep(1000);
                OnSodaEventTrigger(new Log());
                Console.WriteLine("Running " + Thread.CurrentThread.Name + " Amount = " + Amount);
            }
        }

        private void OnSodaEventTrigger(Log log)
        {
            if (SodaThreadEvent != null)
            {
                Log lg = new Log();
                lg.Message = "test event";
                SodaThreadEvent.Invoke(this, lg);
            }
            //SodaThreadEvent?.Invoke(this, lg)
        }
    }
}
