using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public IQuacking Quacking { get; set; }
        public IFlying Flying { get; set; }

        public RubberDuck()
        {
            Quacking = new MuteQuacking();
            Flying = new Flightless();
        }

        public RubberDuck(IQuacking quacking, IFlying flying)
        {
            {
                Quacking = quacking;
                Flying = flying;
            }
        }

        public void Fly()
        {
            Flying.Fly();
        }

        public void Quack()
        {
            Quacking.Quack();
        }
    }
}
