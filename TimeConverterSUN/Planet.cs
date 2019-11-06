using System;
using System.Collections.Generic;
using System.Text;

namespace TimeConverterSUN
{
   public class Planet
    {
        private string nameOfPlanet;
        private string time;


        public string NameOfPlanet
        {
            get { return nameOfPlanet; }
            set { nameOfPlanet = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public Planet(string name, string time)
        {
            NameOfPlanet = name;
            Time = time;
        }
    }
}
