using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SecondFactory : AbstractFactory
    {
        public override IColor GetColor()
        {
            return new Green();
        }

        public override IShape GetShape()
        {
            return new Square();
        }
    }
}
