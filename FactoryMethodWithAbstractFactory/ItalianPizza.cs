using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ItalianPizza : Pizza
    {
        private IIngredientsAbstractFactory _ingredientsFactory;
        public ItalianPizza(IIngredientsAbstractFactory ingredientsAbstractFactory)
        {
            _ingredientsFactory = ingredientsAbstractFactory;
            Name = "Standard Italian pizza";
        }

        public override void Prepare()
        {
            Dough = _ingredientsFactory.CreateDough();
            Sauce = _ingredientsFactory.CreateSauce();
        }
    }
}
