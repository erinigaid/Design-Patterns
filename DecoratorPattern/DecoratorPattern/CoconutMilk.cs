using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class CoconutMilk : ToppingDecorator
    {

        public CoconutMilk(cafe neworder) : base(neworder)
        {
        }
        public double getCost()
        {
            return temporder.getCost()+1.5;
        }

        public string getDescription()
        {
            return temporder.getDescription()+", Coconut Milk";
        }
    }
}
