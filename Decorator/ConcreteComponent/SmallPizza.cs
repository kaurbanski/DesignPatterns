using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class SmallPizza : Pizza
    {
        public override double CalculateCost()
        {
            return 15.0;
        }

        public override string GetName()
        {
            return "Small pizza";
        }
    }
}
