using System;
using System.Collections.Generic;
using System.Text;

namespace SausageWagon2
{
    public class Order
    {


        private Menuitem menu;

        public Menuitem Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        public Order(Menuitem item)
        {
            menu = item;
        }
        public override string ToString()
        {
            return "Orderen består af " + Menu.ToString();
        }
    }
}
