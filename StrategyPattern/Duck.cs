using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public decimal Weight { get; protected set; }
    }
}
