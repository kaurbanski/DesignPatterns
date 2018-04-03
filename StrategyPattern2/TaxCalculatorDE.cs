using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2
{
    public class TaxCalculatorDE : ITaxCalculator
    {
        public decimal Count(decimal price)
        {
            decimal tax = 0.3m;
            return decimal.Multiply(price, tax);
        }
    }
}
