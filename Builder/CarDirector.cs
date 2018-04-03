using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarDirector
    {
        private ICarBuilder carBuilder;

        public CarDirector(ICarBuilder builder)
        {
            carBuilder = builder;
        }

        public void makeCar()
        {
            carBuilder.BuildEngine();
            carBuilder.BuildTires();
        }

        public Car GetCar()
        {
            return carBuilder.GetCar();
        }
    }
}
