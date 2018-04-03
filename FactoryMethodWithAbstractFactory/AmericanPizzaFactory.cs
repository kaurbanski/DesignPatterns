using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AmericanPizzaFactory : Pizzeria
    {
        public override Pizza PreparePizza(string type)
        {
            Pizza pizza = null;
            IIngredientsAbstractFactory americanIngredientsFactory = new AmericanPizzaIngredientsFactory();
            if (type.Equals("standard"))
            {
                pizza = new AmericanPizza(americanIngredientsFactory);
            }
            else if (type.Equals("bacon"))
            {
                pizza = new AmericanPizzaWithBacon(americanIngredientsFactory);
            }
            return pizza;
        }
    }
}
