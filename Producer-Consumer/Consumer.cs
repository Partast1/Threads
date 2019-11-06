using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Producer_Consumer
{
    public class Consumer
    {
        public static void ConsumeFromBuffer()
        {
            Monitor.TryEnter(Program.zeKey);
            {
                if (ProductionBuffer.PrBuffer.Count >= 1)
                {
                    ProductionBuffer.PrBuffer.Dequeue();
                    
                    Console.WriteLine("Consumer removed item: {0}", ProductionBuffer.PrBuffer.Count);

                }
            }
        }
    }
}
