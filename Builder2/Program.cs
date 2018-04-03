using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SchoolComputerBuilder schoolBuilder = new SchoolComputerBuilder();

            ComputerDirector director = new ComputerDirector(schoolBuilder);
            director.makeComputer();

            Computer computer = director.GetComputer();
            Console.WriteLine(computer.GraphicCard.Name);
            Console.ReadLine();
        }
    }
}
