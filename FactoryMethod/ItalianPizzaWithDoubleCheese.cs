using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ItalianPizzaWithDoubleCheese : Pizza
    {
        public ItalianPizzaWithDoubleCheese()
        {
            Name = "Italian pizza with double cheese";
            Dough = "Thin crust";
        }
    }
}
