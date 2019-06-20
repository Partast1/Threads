using System;
using System.Collections.Generic;

namespace Travbane
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Horse> horses = new List<Horse>();

            CreateHorse ch = new CreateHorse();
            horses = ch.NewHorse();
            int count=1;
            horses = CreateRace;
            foreach (Horse item in horses)
            {
                Console.WriteLine("Horse number {0} Speed:{1} Number:{2}",count++, item.Speed, item.Number);
            }
            Console.ReadLine();
            
        }
    }
}
