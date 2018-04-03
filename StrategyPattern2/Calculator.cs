using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2
{
    public class Calculator
    {
        public ITaxCalculator TaxCalculator { get; set; }
        public Calculator(ITaxCalculator taxCalculator)
        {
            TaxCalculator = taxCalculator;
        }

        public decimal CalculatTax(decimal price)
        {
            return TaxCalculator.Count(price);
        }
    }
}
