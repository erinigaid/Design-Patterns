using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class FullFatMilk:ToppingDecorator
    {
        public FullFatMilk(cafe neworder) : base(neworder)
        {
        }
        public double getCost()
        {
            return temporder.getCost() + 3;
        }

        public string getDescription()
        {
            return temporder.getDescription() + ", Full Fat Milk";
        }
    }
}

