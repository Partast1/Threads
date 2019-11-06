using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskeAutomaten
{
    public class Factory
    {
        SerialNumber Sn = new SerialNumber();
        static Random rnd = new Random();
        static string[] BeerNames = { "Tuborg" , "Carsberg" , "Tuborg Classic" };
        static string[] SodaNames = { "Coca Cola", "Faxe Kondi", "Fanta" };
        int rndbeer = rnd.Next(BeerNames.Length);
        int rndsoda = rnd.Next(SodaNames.Length);

        public Beer CreateBeer()
        {
            return new Beer(BeerNames[rndbeer], "Beer", 33, Sn.CreateSNumber());
        }
        public Soda CreateSoda()
        {
            return new Soda(SodaNames[rndsoda], "Soda", 50, Sn.CreateSNumber());
        }
      
    }
}
