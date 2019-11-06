using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTraining
{
    public class Comic : Book, IDownloadBook
    {
        private Person superHero;

        public Person SuperHero
        {
            get { return superHero; }
            set { superHero = value; }
        }

        public string DownloadPath { get; set ; }

        public Comic()
        {

        }
        public Comic(Person hero)
        {
            superHero = hero;
        }
    }
}
