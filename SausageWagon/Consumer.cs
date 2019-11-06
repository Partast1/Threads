using System;
using System.Collections.Generic;
using System.Text;

namespace SausageWagon
{
    public class Consumer
    {
        public void Consume()
        {
            Buffer buf = new Buffer();
            List<Ingredient> FinishedMeals = new List<Ingredient>();
            if (Buffer.Meals.Count > 0)
            {
                Ingredient finishedmeal = buf.Consume();
                Console.WriteLine("Customer got finished meal");
                FinishedMeals.Add(finishedmeal);
            }
            foreach (IPrepable item in FinishedMeals)
            {
                Console.WriteLine(item);
            }

        }

    }
}
