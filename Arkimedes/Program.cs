using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Arkimedes
{
    class Program
    {
        
        public static object zekey = new object();
        static void Main(string[] args)
        {
         List<Philosopher> phils = new List<Philosopher>();

            Program pg = new Program();
            Philosopher Plato = new Philosopher("Plato");
            Philosopher Buddha = new Philosopher("Buddha");
            Philosopher SunTzu = new Philosopher("SunTzu");
            Philosopher Socrates = new Philosopher("Socrates");
            Philosopher Locke = new Philosopher("Locke");
            phils.Add(Plato);
            phils.Add(Buddha);
            phils.Add(SunTzu);
            phils.Add(Socrates);
            phils.Add(Locke);
            Fork fork1 = new Fork("Fork1");
            Fork fork2 = new Fork("Fork2");
            Fork fork3 = new Fork("Fork3");
            Fork fork4 = new Fork("Fork4");
            Fork fork5 = new Fork("Fork5");

            pg.CreatePhilosopher(phils);
            foreach (Philosopher item in phils.ToList())
            {
                int count;
                Thread philosoThread = new Thread(() => pg.CreatePhilosopher(phils));
                //Thread philosoThread = new Thread(pg.Lockingstation(phils[item]));
                philosoThread.Start();
                //ThreadPool.QueueUserWorkItem(pg.CreatePhilosopher => phils);
            }
            //List<Philosopher> philosophers
            Console.ReadLine();

        }
        public  void CreatePhilosopher(List<Philosopher> l)
        {
            List<Philosopher> phils = l;



        }

        // jeg har prøvet at sende en liste til mine methods 
        public void Lockingstation(List<Philosopher> l)
        {
            //List<Philosopher> phils = l;
            Program pg = new Program();


            lock (zekey)
            {
                Console.WriteLine("{0} has {1} equipped", phils., fork1.Name);
                Thread.Sleep(1000);
                lock (zekey)
                {
                    Console.WriteLine("{0} has {1} equipped", pname.Name, fork2.Name);
                    Console.WriteLine("{0} is eating", pname.Name);
                    Thread.Sleep(1000);
                }
            }

        }
        public static void ListHandler(List<Philosopher> l)
        {
            List<Philosopher> K = l;
            //string f = K.IndexOf[0];
            string pname = Convert.ToString(K[0]);
            string fork1 = Convert.ToString(K[1]);
            string fork2 = Convert.ToString(K[2]);

        }

    }
}


