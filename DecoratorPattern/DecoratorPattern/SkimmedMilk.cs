using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class SkimmedMilk:ToppingDecorator
    {
        public SkimmedMilk(cafe neworder) : base(neworder)
        {
        }
        public double getCost()
        {
            return temporder.getCost() + 2;
        }

        public string getDescription()
        {
            return temporder.getDescription() + ", Skimmed Milk";
        }
    }
}

