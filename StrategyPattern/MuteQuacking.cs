using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MuteQuacking : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack!");
        }
    }
}
