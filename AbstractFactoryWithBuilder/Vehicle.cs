using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public abstract class Vehicle
    {
        public string Name { get; protected set; }
        public int QuantityOfTires { get; protected set; }
    }
}
