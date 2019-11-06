using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SausageWagon2
{
    class CompleteMenu
    {
        // These methods takes a list of ingredients.
        public void CreateRoastedHotdog(List<Ingredient> ings)
        {
            Bread br = new Bread("ting");

            //var list = ings.Where(a => a is Bread).ToList();
            
            string roastedHotDog = "Ristet hotdog";

            var  queryBread = from ing in ings
                                            where ings.GetType().Equals(typeof(Bread))
                                       select ing;

            var querySausage = from ing in ings
                             where ings.GetType().Equals(typeof(Sausage))
                             select ing;


            if ((queryBread.Count() > 0) && (querySausage.Count() > 0) )
            {
                lock (ings)
                {
                    ings.Clear();
                    Customer.Consume(roastedHotDog);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen vare");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
        }
        public void CreateBoiledHotdog(List<Ingredient> ings)
        {
            string boiledHotDog = "Kogt hotdog";

            var queryBread = from ing in ings
                             where ings.GetType().Equals(typeof(Bread))
                             select ing;
            var querySausage = from ing in ings
                               where ings.GetType().Equals(typeof(Sausage))
                               select ing;
            if ((queryBread.Count() > 0) && (querySausage.Count() > 0))
            {
                lock (ings)
                {
                    ings.Clear();
                    Customer.Consume(boiledHotDog);
                }
            }
        }
        public void CreateRoastedSausage(List<Ingredient> ings)
        {
            string roastedSausage = "Ristet pølse med brød";

            var queryBread = from ing in ings
                             where ings.GetType().Equals(typeof(Bread))
                             select ing;
            var querySausage = from ing in ings
                               where ings.GetType().Equals(typeof(Sausage))
                               select ing;


            if ((queryBread.Count() > 0) && (querySausage.Count() > 0))
            {
                lock (ings)
                {
                    ings.Clear();
                    Customer.Consume(roastedSausage);
                }
            }
        }
        public void CreateBoiledSausage(List<Ingredient> ings)
        {
            string boiledSausage = "Kogt pølse med brød";

            var queryBread = from ing in ings
                             where ings.GetType().Equals(typeof(Bread))
                             select ing;
            var querySausage = from ing in ings
                               where ings.GetType().Equals(typeof(Sausage))
                               select ing;


            if ((queryBread.Count() > 0) && (querySausage.Count() > 0))
            {
                lock (ings)
                {
                    ings.Clear();
                    Customer.Consume(boiledSausage);
                }
            }
            
        }
        public void CreateBeefSandwish(List<Ingredient> ings)
        {
            string beefSandwish = "Bøfsandwish";


            var queryBread = from ing in ings
                             where ings.GetType().Equals(typeof(Bread))
                             select ing;
            var querySausage = from ing in ings
                               where ings.GetType().Equals(typeof(Sausage))
                               select ing;


            if ((queryBread.Count() > 0) && (querySausage.Count() > 0))
            {
                lock (ings)
                {
                    ings.Clear();
                    Customer.Consume(beefSandwish);
                }
            }
        }
        public void CreateFrenchFries(List<Ingredient> ings)
        {
            string frenchFries = "Pomfritter";
            lock (ings)
            {
                ings.Clear();

                Customer.Consume(frenchFries);
            }
        }
    }
}
