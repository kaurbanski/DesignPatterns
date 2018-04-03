using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AmericanPizzaWithBacon : Pizza
    {
        public AmericanPizzaWithBacon()
        {
            Name = "American pizza with Bacon";
            Dough = "Thick crust";
        }
    }
}
