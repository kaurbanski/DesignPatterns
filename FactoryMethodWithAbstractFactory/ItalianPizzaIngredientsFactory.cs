using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ItalianPizzaIngredientsFactory : IIngredientsAbstractFactory
    {
        public Dough CreateDough()
        {
            return new ThinDough();
        }

        public Sauce CreateSauce()
        {
            return new Ketchup();
        }
    }
}
