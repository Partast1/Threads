using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public class IngredientFactory
    {
        public Ingredient CreateBoiledSausage()
        {
            return new Sausage("Kogt Pølse", 12, 5000);
        }
        public Ingredient CreateSausageBread()
        {
            return new SausageBread("Pølsebrød", 1, 3000);
        }
        public Ingredient CreateRoastedSausage()
        {
            return new Sausage("Ristet Pølse", 1, 3000);
        }
        public Ingredient CreateBurgerBread()
        {
            return new BurgerBun("Pølsebrød", 1, 3000);
        }
        public Ingredient CreateBeef()
        {
            return new SausageBread("Bøf", 1, 3);
        }

    }
}
