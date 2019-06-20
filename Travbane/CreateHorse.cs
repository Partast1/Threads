using System;
using System.Collections.Generic;
using System.Text;

namespace Travbane
{
     class CreateHorse
    {

        public List<Horse> horses = new List<Horse>();

        public List<Horse> NewHorse()
        {
            CreateRace cr = new CreateRace();
            //int hnumber = 0;
            //int speed=0;

            for (int i = 0; i < 8; i++)
            {
                int hnumber = RNumber();
                int speed = RSpeed();
                horses.Add(new Horse(hnumber, speed));

            }
            horses = cr.Race();

            return horses;
        }
        public int RNumber()
        {
            int num;
            Random r = new Random();
            num = r.Next(1, 99);
            return num;
        }
        public int RSpeed()
        {
            int numb;
            Random r = new Random();
            numb = r.Next(50, 65);
            return numb;
        }
    }
}
