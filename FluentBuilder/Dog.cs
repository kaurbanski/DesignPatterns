using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class Dog
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Owner { get; private set; }

        public Dog(DogBuilder builder)
        {
            Name = builder.Name;
            Age = builder.Age;
            Owner = builder.Owner;
        }
    }

}
