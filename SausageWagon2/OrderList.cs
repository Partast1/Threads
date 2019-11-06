using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SausageWagon2
{
    public class OrderList
    {
        //private static Order[] orders = new Order[4];

        //public static Order[] Orders
        //{
        //    get { return orders; }
        //    set { orders = value; }
        //}
        private static Order[] orders = new Order[4];
        public static Order[] Orders 
        {
            get { return orders; }
            set { orders = value; }
        }


        //public Order this[int index]
        //{
        //    get { return Orders[index]; }
        //    set { Orders[index] = value; }
        //}

        //Check if ingredients are available
        //private static Queue<Order> orders = new Queue<Order>();
        //public static Queue<Order> Orders
        //{
        //    get { return orders; }
        //    set { orders = value; }
        //}
        static int maxOrders = 4;
        public static void Add(Order order)
        {
            try
            {
                lock (Orders)
                {
                    if (Orders.Length <= maxOrders)
                    {


                        Orders = new Order[]{ order };
                        Console.WriteLine("Customer ordering... " + order.Menu + ": " + Orders.Length);
                        Thread.Sleep(500);
                    }


                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static Order Remove()
        {
            try
            {
                lock (Orders)
                {
                    if (Orders.Length > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Fjernes nu fra listen {0}", Orders.FirstOrDefault());
                        Console.ForegroundColor = ConsoleColor.Gray;
                        var ordersList = Orders.ToList();
                        ordersList.IndexOf[0];
                        return Orders.Skip(Remove()).ToArray();

                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
