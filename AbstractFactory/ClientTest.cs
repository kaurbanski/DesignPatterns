using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ClientTest
    {
        private AbstractFactory clientFactory;

        public ClientTest(AbstractFactory factory)
        {
            clientFactory = factory;
        }

        public void CreateTest()
        {
            IShape shape = clientFactory.GetShape();
            IColor color = clientFactory.GetColor();
            shape.Draw();
            color.Fill();
            Console.WriteLine("Test generated");
        }
    }
}
