using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public class CoffeeDecorator : Coffee
    {
        Coffee coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }
        public override string GetName()
        {
            return coffee.GetName();
        }

        public override double GetPrice()
        {
            return coffee.GetPrice();
        }
    }
}
