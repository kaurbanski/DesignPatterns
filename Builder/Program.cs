using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CorsaBuilder corsaBuilder = new CorsaBuilder("Korsina");
            CarDirector director = new CarDirector(corsaBuilder);
            director.makeCar();
            Car car = director.GetCar();
            Console.WriteLine(car.engine.Type);
            Console.ReadLine();
        }
    }
}
