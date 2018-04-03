using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new CheeseDecorator(largePizza);
            largePizza = new HamDecorator(largePizza);
            largePizza = new ChampignonsDecorator(largePizza);
            Console.WriteLine(largePizza.CalculateCost());
            Console.WriteLine(largePizza.GetName());
            Console.ReadLine();
        }
    }
}
