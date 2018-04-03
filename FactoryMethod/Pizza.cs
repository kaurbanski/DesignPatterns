using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }
        public void Bake()
        {
            Console.WriteLine("Bake pizza");
        }


    }
}
