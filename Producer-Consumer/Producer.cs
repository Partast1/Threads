using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Producer_Consumer
{
    public class Producer
    {
        // the producer class PRODUCETOBUFFER Creates a new instance of productionitem, Locks on the key objects
        public static void ProduceToBuffer()
        {
            ProductionItem pi = new ProductionItem();
            Thread.Sleep(1000);
            Monitor.TryEnter(Program.zeKey);
            {
                ProductionBuffer.Bufferclass(pi);
                Thread.Sleep(1000);

            }
            
        }
    }
}
