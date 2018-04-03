using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Squeking : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Piiiii piiiiii");
        }
    }
}
