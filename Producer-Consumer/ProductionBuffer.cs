using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Producer_Consumer
{
    public class ProductionBuffer
    {
        private static Queue<ProductionItem> pBuffer;

        public static Queue<ProductionItem> PBuffer
        {
            get { return pBuffer; }
            set { pBuffer = value; }
        }
        public ProductionBuffer(Queue<ProductionItem> cbuffer)
        {
            pBuffer = cbuffer;
        }
        public static Queue<ProductionItem> PrBuffer = new Queue<ProductionItem>();

        public static void Bufferclass(ProductionItem pi)
        {
            if (PrBuffer.Count <= 4)
            {
                PrBuffer.Enqueue(pi);
                Console.WriteLine("Producer created an item {0}", PrBuffer.Count);
            }
            else
            {
                Console.WriteLine("Productions Buffer is full");
            }
        }
    }
}
