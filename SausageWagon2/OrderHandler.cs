using System;
using System.Collections.Generic;
using System.Text;

namespace SausageWagon2
{
    class OrderHandler
    {

        //This method gets a random number from the ENUM Menu
        
        public void CreateOrder()
        {
            Array values = Enum.GetValues(typeof(Menuitem));
            Random random = new Random();
            Menuitem rndmenu = (Menuitem)values.GetValue(random.Next(values.Length));
            
            OrderList.Add(new Order(rndmenu));
        }
    }
}
