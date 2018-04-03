using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public abstract class AbstractFactory
    {
        public abstract IGarage CreateGarage();
        public abstract IVehicle CreateVehicle();
    }
}
