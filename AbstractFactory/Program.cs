using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClientTest test;

            test = new ClientTest(new FirstFactory());
            test.CreateTest();

            test = new ClientTest(new SecondFactory());
            test.CreateTest();
            Console.ReadLine();

        }
    }
}
