using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder2
{
    public class Hamburger
    {
        public string Bread { get; private set; }
        public string Meat { get; private set; }
        public string Sauce { get; private set; }

        public Hamburger(HamburgerBuilder builder)
        {
            Bread = builder.Bread;
            Meat = builder.Meat;
            Sauce = builder.Sauce;
        }
    }
}
