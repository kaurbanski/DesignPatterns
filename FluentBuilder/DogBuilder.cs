using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class DogBuilder
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Owner { get; private set; }

        public DogBuilder(string name)
        {
            Name = name;
        }

        public DogBuilder SetAge(int age)
        {
            Age = age;
            return this;
        }

        public DogBuilder SetOwner(string owner)
        {
            Owner = owner;
            return this;
        }

        public Dog Build()
        {
            return new Dog(this);
        }
    }
}
