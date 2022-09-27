using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ToppingDecorator : cafe
    {
        protected cafe temporder;
        public ToppingDecorator(cafe neworder)
        {
            temporder = neworder;
        }
        public double getCost()
        {
            return temporder.getCost();
        }

        public string getDescription()
        {
            return temporder.getDescription();
        }
    }
}
