using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class MediumPizza : Pizza
    {
        public override double CalculateCost()
        {
            return 30.0;
        }

        public override string GetName()
        {
            return "Medium pizza";
        }
    }
}
