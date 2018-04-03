using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2
{
    public interface ITaxCalculator
    {
        decimal Count(decimal price);
    }
}
