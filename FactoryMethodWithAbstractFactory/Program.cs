using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Pizzeria americanPizzaFactory = new AmericanPizzaFactory();
            Pizza standard = americanPizzaFactory.OrderPizza("standard");
            standard.Prepare();
            Console.WriteLine(standard.Name);
            Console.WriteLine(standard.Dough);
            Console.ReadLine();
        }
    }
}
