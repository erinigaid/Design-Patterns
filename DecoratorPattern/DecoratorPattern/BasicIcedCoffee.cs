using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class BasicIcedCoffee : cafe
    {
        public double getCost()
        {
            return 7.0;
        }

        public string getDescription()
        {
            return "Plain Iced coffee";
        }
    }
}
