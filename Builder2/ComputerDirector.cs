using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class ComputerDirector
    {
        IComputerBuilder builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            this.builder = builder;
        }

        public void makeComputer()
        {
            builder.BuildGraphicCard();
            builder.BuildHDD();
        }

        public Computer GetComputer()
        {
            return builder.GetComputer();
        }
    }
}
