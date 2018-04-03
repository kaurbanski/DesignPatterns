using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Component;

namespace Decorator.ConcreteDecorator
{
    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 5;
        }
        public override string GetName()
        {
            return base.GetName() + " ham";
        }
    }
}
