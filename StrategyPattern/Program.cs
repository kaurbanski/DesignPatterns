using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WildDuck wildDuck = new WildDuck();
            wildDuck.Quack();
            wildDuck.Fly();

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Quack();
            rubberDuck.Fly();
            rubberDuck.Flying = new Flying();
            rubberDuck.Fly();


            Console.ReadLine();
        }
    }
}
