using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffe = new Espresso();
            Console.WriteLine(coffe.GetPrice());
            coffe = new MilkDecorator(coffe);
            Console.WriteLine(coffe.GetName());
            Console.ReadLine();
        }
    }
}
