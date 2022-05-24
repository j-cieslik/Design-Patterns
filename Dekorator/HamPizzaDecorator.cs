using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dekorator
{
    public class HamPizzaDecorator : PizzaDecorator
    {
        public HamPizzaDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 5; 
        }
    }
}