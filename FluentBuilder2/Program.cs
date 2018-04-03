using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HamburgerBuilder builder = new HamburgerBuilder();
            Hamburger hamburger = builder
                .SetBred("żytnie")
                .SetMeat("chicken")
                .SetSauce("ketchup")
                .Build();
        }
    }
}
