using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public class Scooter : Vehicle, IVehicle
    {
        public string InscriptionOnTheSticker { get; private set; }

        public Scooter(ScooterBuilder builer)
        {
            Name = builer.Name;
            InscriptionOnTheSticker = builer.InscriptionOnTheSticker;
            QuantityOfTires = builer.QuantityOfTires;
        }

        public void Brake()
        {
            Console.WriteLine("Scooter brake");
        }

        public void Drive()
        {
            Console.WriteLine("Scooter drive");
        }
    }
}
