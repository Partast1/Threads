//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Arkimedes
//{
//    public class Forkequipment
//    {

//        public Fork fork1 = new Fork("Fork1");
//        public Fork fork2 = new Fork("Fork2");
//        public Fork fork3 = new Fork("Fork3");
//        public Fork fork4 = new Fork("Fork4");
//        public Fork fork5 = new Fork("Fork5");

//        public static List<Philosopher> CreatePhilosopher()
//        {
//            List<Philosopher> phils = new List<Philosopher>();
//            Philosopher Plato = new Philosopher("Plato", fork1, fork2);
//            Philosopher Buddha = new Philosopher("Buddha", fork2, fork3);
//            Philosopher SunTzu = new Philosopher("SunTzu", fork3, fork4);
//            Philosopher Socrates = new Philosopher("Socrates", fork4, fork5);
//            Philosopher Locke = new Philosopher("Locke", fork5, fork1);
//            phils.Add(Plato);
//            phils.Add(Buddha);
//            phils.Add(SunTzu);
//            phils.Add(Socrates);
//            phils.Add(Locke);


//            return phils;
//        }

//    }
//}
