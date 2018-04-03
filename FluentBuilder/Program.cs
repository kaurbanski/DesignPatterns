using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DogBuilder dogBuilder = new DogBuilder("Azor");
            Dog dog = dogBuilder.SetAge(12).Build();
            Console.WriteLine(dog.Age.ToString() + dog.Name + dog.Owner);
            Console.ReadLine();
        }
    }
}
