using System;
using System.Collections.Generic;
using System.Text;

namespace TimeConverterSUN
{
    public class Program
    {
        public void Planets()
        {
            List<Planet> ourplanets = new List<Planet>();
            //ourplanets.Add("Sun", "27:06:36:00");
            ourplanets.Add(new Planet("Sol", "27:06:36:00") { NameOfPlanet = "Sol", Time = "27:06:36:00" });

        }
        static void Main(string[] args)
        {
            //char[] determinationChars = { 'a', 'd', 't', 'm', 's' };

            //string[] calculated = dbTime.Split(determinationChars);
            //double secs;
            //switch (calculated)
            //{
            //    case a:
            //        secs = secs + 31557600;
            //        break;
            //}
            
            string dbTime = "1a10d15t25m24s";
            Program.converter(dbTime);
            //dbTime = dbTime.Replace('a', ':').Replace('d', ':').Replace('t', ':').Replace('m', ':').Replace('s', ' ');

            //string format = "yy:dd:mm:ss";

            //var now = DateTime.Now;
            //s = s.Replace('a', ':').Replace('d', ':').Replace('t', ':').Replace('m', ':').Replace('s', ' ');


            //Console.WriteLine(dbTime);

            //double seconds = TimeSpan.Parse(dbTime).TotalSeconds;
            //Console.WriteLine(seconds);
            Console.ReadLine();
        }
        public static void converter(string str)
        {
            char[] determinationChars = { 'a', 'd', 't', 'm', 's' };
            if (determinationChars == 'a')
            {

            }
            string[] calculated = str.Split.years(determinationChars);
        
            Dictionary<string, decimal> temp = new Dictionary<string, decimal>();
            // 12a 43d 10t 50m 14s

            foreach (string item in calculated)
            {
                temp.Add("a", Decimal.Parse("200"));

            }

            decimal years = 0;
            decimal days = 0;
            decimal hours = 0;
            decimal minutes = 0;
            decimal seconds = 0;
            
            //Console.WriteLine(s);
        }
        //public static DateTime ParseMilitaryTime(string time,
        //  int year, int month, int day)
        //{
        //    //
        //    // Convert hour part of string to integer.
        //    //
        //    string hour = time.Substring(0, 2);
        //    int hourInt = int.Parse(hour);
        //    if (hourInt >= 24)
        //    {
        //        throw new ArgumentOutOfRangeException("Invalid hour");
        //    }
        //}
    }
}
