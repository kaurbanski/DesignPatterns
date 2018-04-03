using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SmallGarageAndScooterFactory factory = new SmallGarageAndScooterFactory();

            var scooter = (Scooter)factory.CreateVehicle();


            Console.WriteLine(scooter.InscriptionOnTheSticker);
            scooter.Drive();
            Console.ReadLine();
        }
    }
}
