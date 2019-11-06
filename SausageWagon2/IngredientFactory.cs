using System;
using System.Collections.Generic;
using System.Text;

namespace SausageWagon2
{
    class IngredientFactory
    {

        //These methods create the required ingredients
        public static Ingredient CreateSausage()
        {
            return new Sausage("Pølse");
        }
      
        public static Ingredient CreateBread()
        {
            return new Bread("Pølsebrød");
        }
        public static Ingredient CreateBeef()
        {
            return new Beef("Bøf");
        }
        public static Ingredient CreateFries()
        {
            return new Fry("Pomfritter");
        }
    }
}
