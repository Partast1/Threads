using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Flaske
{
    class Program
    {
        //Queues acts as buffers between producer and consumer 
        public static Queue<Product> products = new Queue<Product>();

        public static Queue<Product> beer = new Queue<Product>();
        public static Queue<Product> soda = new Queue<Product>();
        public static object zekey = new object();

        static void Main(string[] args)
        {

            Program pd = new Program();
            while (true)
            {
                //Threads Created for production, solitter & Consumer
                Thread produceBeer = new Thread(CreateProductBeer);
                Thread produceSoda = new Thread(CreateProductSoda);
                Thread splitterThread = new Thread(Splitter);
                Thread consumeSoda = new Thread(SodaConsumer);
                Thread consumeBeer = new Thread(BeerConsumer);

                //Threads started
                produceBeer.Start();
                produceSoda.Start();
                splitterThread.Start();
                //splitterThread.Join();
                consumeSoda.Start();
                consumeBeer.Start();
            }
        }

        #region Create
        public static void CreateProductBeer(object ob)
        {
            SerialNumber sn = new SerialNumber();
            if (products.Count < 6)
            {
                Monitor.TryEnter(products, 500);
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Product pdtb = new Product("Beer", sn.CreateSNumber());
                        products.Enqueue(pdtb);
                    }
                }
                Monitor.Exit(products);
            }
            else
            {
                Thread.Sleep(1000);
            }

        }
        public static void CreateProductSoda(object ob)
        {
            SerialNumber sn = new SerialNumber();
            if (products.Count < 6)
            {
                Monitor.TryEnter(products, 500);
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Product pdts = new Product("Soda", sn.CreateSNumber());
                        products.Enqueue(pdts);
                    }
                }
                Monitor.Exit(products);
            }
            else
            {
                //Thread.Sleep(1100);
            }
        }
        #endregion

        public static void Splitter(object ob)
        {
            //if (products.Count >= 1)
            //{
            Console.WriteLine("Products count {0}", products.Count);
            Monitor.TryEnter(products, 500);
            {
                Console.WriteLine("We are in the Queue bitches");
                foreach (Product item in products.ToList())

                {
                    if (item.ProductName == "Soda")
                    {
                        soda.Enqueue(item);

                        Console.WriteLine("added soda to soda Queue {0}", soda.Count);
                        

                    }
                    else if (item.ProductName == "Beer")
                    {
                        beer.Enqueue(item);

                        Console.WriteLine("added beer to beer Queue {0}", beer.Count);
                        
                    }
                    else { Console.WriteLine("Hej"); }
                    products.Dequeue();

                }
                Monitor.Exit(products);
            }

        }
        public static void SodaConsumer()
        {
            if (soda.Count > 3)
            {
                Monitor.TryEnter(products, 500);
                //each Products is consumed by the consumer
                foreach (Product item in soda.ToList())
                {
                    soda.Dequeue();
                    Console.WriteLine("Soda was consumed...");
                }
                    Monitor.Exit(products);
            }
        }
        public static void BeerConsumer()
        {
            if (beer.Count > 3)
            {
                Monitor.TryEnter(products, 500);
                //each Products is consumed by the consumer
                foreach (Product item in beer.ToList())
                {
                    beer.Dequeue();
                    Console.WriteLine("Beer was consumed...");
                }
                Monitor.Exit(products);
            }
        }
    }
}
