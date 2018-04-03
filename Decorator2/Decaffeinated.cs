using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator2
{
    public class Decaffeinated : Coffee
    {
        public override string GetName()
        {
            return "Decaffeinated";
        }

        public override double GetPrice()
        {
            return 7.0;
        }
    }
}
