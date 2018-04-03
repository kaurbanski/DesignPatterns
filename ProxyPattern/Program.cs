using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImageInterface proxyImage = new ImageProxy();
            Console.WriteLine(proxyImage.GetImage());

            Console.WriteLine(proxyImage.GetImage());
            Console.ReadLine();
        }
    }
}
