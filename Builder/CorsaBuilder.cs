using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CorsaBuilder : ICarBuilder
    {
        private Car car;

        public CorsaBuilder(string name)
        {
            car = new Car();
            car.name = name;
        }

        public void BuildEngine()
        {
            Engine engine = new Engine();
            engine.Type = "benzyna";
            car.engine = engine;
        }

        public void BuildTires()
        {
            Tires tires = new Tires();
            tires.Durability = 80;
            car.tires = tires;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
