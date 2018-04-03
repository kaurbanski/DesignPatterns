using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Quacking : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack!");
        }
    }
}
