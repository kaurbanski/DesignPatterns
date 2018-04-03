using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public class Espresso : Coffee
    {
        public override string GetName()
        {
            return "Espresso";
        }

        public override double GetPrice()
        {
            return 5.0;
        }
    }
}
