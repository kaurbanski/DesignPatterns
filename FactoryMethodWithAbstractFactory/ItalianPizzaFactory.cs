using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ItalianPizzaFactory : Pizzeria
    {
        public override Pizza PreparePizza(string type)
        {
            Pizza pizza = null;
            ItalianPizzaIngredientsFactory ingredientsFactory = new ItalianPizzaIngredientsFactory();
            if (type.Equals("standard"))
            {
                pizza = new ItalianPizza(ingredientsFactory);
            }
            return pizza;
        }
    }
}
