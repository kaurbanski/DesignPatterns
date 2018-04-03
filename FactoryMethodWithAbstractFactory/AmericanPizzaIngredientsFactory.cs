using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AmericanPizzaIngredientsFactory : IIngredientsAbstractFactory
    {
        public Dough CreateDough()
        {
            return new ThickDough();
        }

        public Sauce CreateSauce()
        {
            return new MayonnaiseSauce();
        }
    }
}
