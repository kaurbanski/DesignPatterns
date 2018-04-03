using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee) : base(coffee)
        {
        }

        public override string GetName()
        {
            return base.GetName() + " milk";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 1.0;
        }
    }
}
