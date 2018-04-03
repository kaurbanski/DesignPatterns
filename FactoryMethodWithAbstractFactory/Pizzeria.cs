using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizzeria
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = PreparePizza(type);
            pizza.Bake();
            pizza.Cut();
            return pizza;

        }
        public abstract Pizza PreparePizza(string type);
    }
}
