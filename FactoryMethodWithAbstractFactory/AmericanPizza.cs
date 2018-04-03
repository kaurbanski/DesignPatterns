using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AmericanPizza : Pizza
    {
        private IIngredientsAbstractFactory _ingredientsFactory;
        public AmericanPizza(IIngredientsAbstractFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
            Name = "Standarc america pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare pizza...");
            Dough = _ingredientsFactory.CreateDough();
            Sauce = _ingredientsFactory.CreateSauce();
        }
    }
}
