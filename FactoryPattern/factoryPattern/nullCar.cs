using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class nullCar : ICar
    {
        public string getName()
        {
            return string.Empty;
        }

        public void move()
        {

        }
    }
}
