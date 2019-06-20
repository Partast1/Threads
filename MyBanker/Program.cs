using System;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            CardNumber cn = new CardNumber();
            DateTime dt = DateTime.Now;
            Maestro mst = new Maestro("Ole", "Jensen", cn.CreateCNumber(14), dt.AddYears(3), "23", 18);
            DebitCard dbc = new DebitCard("Jørgen", "Hansen", cn.CreateCNumber(14), dt.AddYears(3), "23");
            Electron ect = new Electron("Ulla", "Helstrup", cn.CreateCNumber(14), dt.AddYears(3), "23", 10000, 15);
            Visa via = new Visa("Ole", "Jensen", cn.CreateCNumber(14), dt.AddYears(3), "23", 20000, 25000, 18);
            Master mtr = new Master("Ole", "Jensen", cn.CreateCNumber(14), dt.AddYears(3), "23", 30000, 40000, 5000);
            Console.WriteLine("{0}{1}{2}{3}{4}",mst.FirstName,mst.LastName,mst.Cardnumber,mst.ExpirationDate,mst.Accountnumber);
        }
    }
}
