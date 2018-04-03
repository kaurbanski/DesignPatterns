using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AmericanPizzaWithBacon : Pizza
    {
        private IIngredientsAbstractFactory _ingredientsFactory;
        public AmericanPizzaWithBacon(IIngredientsAbstractFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
        }
        public AmericanPizzaWithBacon()
        {
            Name = "American pizza with Bacon";
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare pizza...");
            Dough = _ingredientsFactory.CreateDough();
            Sauce = _ingredientsFactory.CreateSauce();
        }
    }
}
