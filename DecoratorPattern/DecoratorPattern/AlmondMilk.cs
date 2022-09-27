using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class AlmondMilk : ToppingDecorator
    {
        public AlmondMilk(cafe neworder): base(neworder)
        {
           
        }
        public double getCost()
        {
            return temporder.getCost() + 1.5;
        }

        public string getDescription()
        {
            return temporder.getDescription() + ", Almond Milk";
        }
    }
}

