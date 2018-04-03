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
        public Dough Dough { get; protected set; }
        public Sauce Sauce { get; protected set; }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }
        public void Bake()
        {
            Console.WriteLine("Bake pizza");
        }
        public abstract void Prepare();
    }
}
