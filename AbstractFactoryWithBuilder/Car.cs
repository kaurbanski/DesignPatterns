using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public class Car : Vehicle, IVehicle
    {
        public int quantityOfSeats { get; private set; }

        public void Brake()
        {
            Console.WriteLine("Car brake");
        }

        public void Drive()
        {
            Console.WriteLine("Car drive");
        }
    }
}
