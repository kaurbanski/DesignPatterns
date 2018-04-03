using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FirstFactory : AbstractFactory
    {
        public override IColor GetColor()
        {
            return new Red();
        }

        public override IShape GetShape()
        {
            return new Rectangle();
        }
    }
}
