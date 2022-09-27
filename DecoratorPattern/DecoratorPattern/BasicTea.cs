using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class BasicTea:cafe
    {
        public double getCost()
        {
            return 2.0;
        }

        public string getDescription()
        {
            return "Plain tea";
        }
    }
}

