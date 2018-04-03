using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        public string name { get; set; }
        public Engine engine { get; set; }
        public Tires tires { get; set; }
    }
}
