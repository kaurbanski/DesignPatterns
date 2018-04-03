using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public class SmallGarageAndScooterFactory : AbstractFactory
    {
        public override IGarage CreateGarage()
        {
            return new SmallGarage();
        }

        public override IVehicle CreateVehicle()
        {
            ScooterBuilder builder = new ScooterBuilder();
            Scooter scooter = builder.SetName("hulajnoga").SetQuantityOfTires(2).SetInscriptionOnTheSticker("hul").Build();
            return scooter;
        }
    }
}
