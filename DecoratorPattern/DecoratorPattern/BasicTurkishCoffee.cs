using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class BasicTurkishCoffee:cafe
    {
        public double getCost()
        {
            return 5.0;
        }

        public string getDescription()
        {
            return "Plain Turkish coffee";
        }
    }
}
