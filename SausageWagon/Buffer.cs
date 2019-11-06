using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class Buffer
    {
        int buffersize = 60;



        private static Queue<Ingredient> meals = new Queue<Ingredient>();

        public static Queue<Ingredient> Meals
        {
            get { return meals; }
            set { meals = value; }
        }

      


        public void Produce(Ingredient meal)
        {
            if (Meals.Count > 0)
            {
                Console.WriteLine("Buffer works");
            }
            //if (Meals.Count < buffersize)
            //{
                Meals.Enqueue(meal);
                Console.WriteLine("meal added to buffer count:{0}",Meals.Count);

            //}
        }
        public Ingredient Consume()
        {
            Ingredient meal = meals.Dequeue();
            Console.WriteLine("removed from queue");
            return meal;
        }
    }
}
