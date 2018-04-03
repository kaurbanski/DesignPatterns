using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill green");
        }
    }
}
