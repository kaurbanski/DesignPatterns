using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class WildDuck : Duck
    {
        public IFlying Flying { get; private set; }
        public IQuacking Quacking { get; private set; }

        public WildDuck()
        {
            Flying = new Flying();
            Quacking = new Quacking();
        }

        public WildDuck(IFlying flying, IQuacking quacking)
        {
            Flying = flying;
            quacking = Quacking;
        }

        public void Quack()
        {
            Quacking.Quack();
        }

        public void Fly()
        {
            Flying.Fly();
        }
    }
}
