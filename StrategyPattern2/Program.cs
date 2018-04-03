using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ITaxCalculator en = new TaxCalculationEN();
            ITaxCalculator de = new TaxCalculatorDE();
            ITaxCalculator pl = new TaxCalculatorPL();
            decimal price = 100;

            Calculator calculator = new Calculator(en);
            Console.WriteLine(calculator.CalculatTax(price));
            calculator.TaxCalculator = de;
            Console.WriteLine(calculator.CalculatTax(price));
            calculator.TaxCalculator = pl;
            Console.WriteLine(calculator.CalculatTax(price));
            Console.ReadLine();
        }
    }
}
