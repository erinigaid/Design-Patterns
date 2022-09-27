using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class BasicCoffee : cafe
    {
        public double getCost()
        {
            return 4.0;
        }

        public string getDescription()
        {
            return "Plain coffee";
        }
    }
}
