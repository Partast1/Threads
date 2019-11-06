using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SausageWagon2
{
    class Chef
    {
        Thread thr;
        Random rnd = new Random();
        private List<Ingredient> ings = new List<Ingredient>();
        public List<Ingredient> Ings
        {
            get { return ings; }
            set { ings = value; }
        }
        public Chef()
        {
                thr = new Thread(MakeFood);
                thr.Name = "Cooking thread";
                thr.Start();
        }
        //MakeFood checker om der er en order at gå i gang med.
        //Hvis der er en order, laver den nye ingredientser og sender dem videre til CompleteMenu.
        public void MakeFood()
        {
            while (true)
            {
                if (OrderList.Orders.Count != 0)
                {
                    Bread b = null;
                    Sausage s = null;
                    Beef be = null;
                    Fry f = null;

                    CompleteMenu menu = new CompleteMenu();
                    Order ord = OrderList.Orders.Peek();
                    switch (ord.Menu)
                    {
                        case Menuitem.RoastedHotdog:
                            lock (ings)
                            {
                                Console.WriteLine("Starting order");
                                b = Toaster.Remove();
                                s = Grill.RemoveSausage();
                                ings.Add(b);
                                ings.Add(s);
                                menu.CreateRoastedHotdog(ings);
                                OrderList.Remove();
                            }
                          
                            break;

                        case Menuitem.NormalHotdog:
                            lock (ings)
                            {
                                Console.WriteLine("Starting order");
                                b = Toaster.Remove();
                                s = Boiler.Remove();
                                ings.Add(b);
                                ings.Add(s);
                                menu.CreateBoiledHotdog(ings);
                                OrderList.Remove();

                            }

                            break;

                        case Menuitem.RoastetSausageBread:
                            lock (ings)
                            {
                                Console.WriteLine("Starting order");
                                b = Toaster.Remove();
                                s = Grill.RemoveSausage();
                                ings.Add(b);
                                ings.Add(s);
                                menu.CreateRoastedSausage(ings);
                                OrderList.Remove();

                            }

                            break;

                        case Menuitem.BoiledSausageBread:
                            lock (ings)
                            {
                                Console.WriteLine("Starting order");
                                b = Toaster.Remove();
                                s = Boiler.Remove();
                                ings.Add(b);
                                ings.Add(s);
                                menu.CreateBoiledSausage(ings);
                                OrderList.Remove();

                            }

                            break;

                        case Menuitem.BeefSandwish:
                            lock (ings)
                            {
                                Console.WriteLine("Starting order");
                                b = Toaster.Remove();
                                be = Grill.RemoveBeef();
                                ings.Add(b);
                                ings.Add(be);
                                menu.CreateBeefSandwish(ings);
                                OrderList.Remove();

                            }

                            break;
                        case Menuitem.Fries:
                            lock (ings)
                            {
                                Console.WriteLine("Starting order");
                                f = Fryer.Remove();
                                ings.Add(f);
                                menu.CreateFrenchFries(ings);
                                OrderList.Remove();

                            }

                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Toaster.Check();
                    Grill.CheckBeef();
                    Grill.CheckSausage();
                    Boiler.Check();
                }
            }

        }
 
    }
}
