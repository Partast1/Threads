using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class Order
    {
        IngredientFactory fac = new IngredientFactory();
        Producer pro = new Producer();

        public Order(Menuitem menu)
        {
            switch (menu)
            {
                case Menuitem.RoastedHotdog:
                    CreateRoastHotdog();
                    break;
                case Menuitem.NormalHotdog:
                   CreateHotdog();
                    break;
                case Menuitem.RoastetSausageBread:
                    CreateRoastSausage();
                    break;
                case Menuitem.BoiledSausageBread:
                    CreateBoiledSausage();
                    break;
                case Menuitem.BeefSandwish:
                    CreateBeefSandwish();
                    break;
                case Menuitem.Fries:
                    CreateFrenchFries();
                    break;
                default:
                    break;
            }
        }
       private void CreateRoastHotdog()
        {
            pro.NewOrder(fac.CreateSausageBread());
            pro.NewOrder(fac.CreateRoastedSausage());
            
        }
       private void CreateHotdog()
        {
            pro.NewOrder(fac.CreateRoastedSausage());
            pro.NewOrder(fac.CreateSausageBread());


        }
       private void CreateRoastSausage()
        {
            pro.NewOrder(fac.CreateRoastedSausage());
            pro.NewOrder(fac.CreateSausageBread());
        }
       private void CreateBoiledSausage()
        {
            pro.NewOrder(fac.CreateBoiledSausage());
            pro.NewOrder(fac.CreateSausageBread());
        }
       private void CreateBeefSandwish()
        {
            pro.NewOrder(fac.CreateBeef());
            pro.NewOrder(fac.CreateBurgerBread());

        }
       private void CreateFrenchFries()
        {

        }
    }
}
