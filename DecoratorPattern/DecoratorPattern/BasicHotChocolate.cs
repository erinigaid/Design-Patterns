using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class BasicHotChocolate:cafe
    {
        public double getCost()
        {
            return 10.0;
        }

        public string getDescription()
        {
            return "Plain Hot Chocolate";
        }
    }
}
