using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventNU2
{
    class Producer
    {
        public delegate void ProducerLogEventHandler(object sender,Log message);
        public event ProducerLogEventHandler ProducerRequestEvent;

        Thread thr;

        public Producer()
        {
            thr = new Thread(StartThread)
            {
                Name = "Product",
                Priority = ThreadPriority.AboveNormal
            };
            thr.Start();
        }
        private void StartThread()
        {
            Console.WriteLine("Starting Thread");
            RunThread();
        }
        private void RunThread()
        {
            while (true)
            {
                Thread.Sleep(1000);
                OnProducerEventTrigger(new Log());
                Console.WriteLine("Running " + Thread.CurrentThread.Name );
            }
        }
        private void OnProducerEventTrigger(Log message)
        {
            //string logmessage = Convert.ToString(message);
            Consumer con = new Consumer();
            
            
                if(ProducerRequestEvent != null)
                {
                    Log lg = new Log();
                    lg.Message = "Testing";
                    ProducerRequestEvent.Invoke(this, lg);
                    
                }
            
        }
    }
}
