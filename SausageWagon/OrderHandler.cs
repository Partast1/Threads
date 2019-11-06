using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    class OrderHandler
    {
        public void CreateOrder()
        {
    
            Array values = Enum.GetValues(typeof(Menuitem));
            Random random = new Random();
            Menuitem rndmenu = (Menuitem)values.GetValue(random.Next(values.Length));
            new Order(rndmenu);

            //switch (rndmenu)
            //{
            //    case Menuitem.RoastedHotdog:
            //        ord.CreateRoastHotdog(Menuitem.RoastedHotdog);
            //        break;
            //    case 1:
            //        ord.CreateHotdog();
            //        break;
            //    case 2:
            //        ord.CreateRoastSausage();
            //        break;
            //    case 3:
            //        ord.CreateBoiledSausage();
            //        break;
            //    case 4:
            //        ord.CreateBeefSandwish();
            //        break;
            //    case 5:
            //        ord.CreateFrenchFries();
            //        break;
            //    default:
            //        break;
            //}

            //Random rnd = new Random();
            //var myEnumMemberCount = Enum.GetNames(typeof(Menuitem)).Length;
            //rnd.Next(0, myEnumMemberCount);

            //switch (Menuitem[myEnumMemberCount])
            //{
            //    case Menuitem.RoastedHotdog:
            //        break;
            //    case Menuitem.NormalHotdog:
            //        break;
            //    case Menuitem.RoastetSausageBread:
            //        break;
            //    case Menuitem.BoiledSausageBread:
            //        break;
            //    case Menuitem.BeefSandwish:
            //        break;
            //    case Menuitem.Fries:
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}