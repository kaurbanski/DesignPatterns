using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder2
{
    public class HamburgerBuilder
    {
        public string Meat { get; private set; }
        public string Bread { get; private set; }
        public string Sauce { get; private set; }

        public HamburgerBuilder() { }

        public HamburgerBuilder SetMeat(string meat)
        {
            Meat = meat;
            return this;
        }

        public HamburgerBuilder SetBred(string bread)
        {
            Bread = bread;
            return this;
        }

        public HamburgerBuilder SetSauce(string sauce)
        {
            Sauce = sauce;
            return this;
        }

        public Hamburger Build()
        {
            return new Hamburger(this);
        }
    }
}
