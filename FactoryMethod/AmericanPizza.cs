using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AmericanPizza : Pizza
    {
        public AmericanPizza()
        {
            Name = "Standarc america pizza";
            Dough = "Thick crust";
        }
    }
}
