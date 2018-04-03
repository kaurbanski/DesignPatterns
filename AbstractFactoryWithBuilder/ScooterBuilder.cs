using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithBuilder
{
    public class ScooterBuilder
    {
        public string Name { get; private set; }
        public int QuantityOfTires { get; private set; }
        public string InscriptionOnTheSticker { get; private set; }

        public ScooterBuilder SetName(string name)
        {
            Name = name;
            return this;
        }

        public ScooterBuilder SetQuantityOfTires(int quantity)
        {
            QuantityOfTires = quantity;
            return this;
        }

        public ScooterBuilder SetInscriptionOnTheSticker(string inscription)
        {
            InscriptionOnTheSticker = inscription;
            return this;
        }

        public Scooter Build()
        {
            return new Scooter(this);
        }
    }
}
