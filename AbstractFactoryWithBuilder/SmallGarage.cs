using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public class SmallGarage : IGarage
    {
        public void Close()
        {
            Console.WriteLine("Opening garage");
        }

        public void Open()
        {
            Console.WriteLine("Closing garage");
        }
    }
}
