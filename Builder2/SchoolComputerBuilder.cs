using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class SchoolComputerBuilder : IComputerBuilder
    {
        private Computer Computer;

        public SchoolComputerBuilder()
        {
            Computer = new Computer();
        }

        public void BuildGraphicCard()
        {
            GraphicCard card = new GraphicCard();
            card.Name = "GTX1080";
            card.Producer = "Asus";
            Computer.GraphicCard = card;
        }

        public void BuildHDD()
        {
            HDD hdd = new HDD();
            hdd.Producer = "Toshiba";
            hdd.Name = "CHS104";
            Computer.HDD = hdd;
        }

        public Computer GetComputer()
        {
            return this.Computer;
        }
    }
}
