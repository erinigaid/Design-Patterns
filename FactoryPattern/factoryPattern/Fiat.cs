using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class Fiat : ICar
    {
        public string getName()
        {
            return "Fiat";

        }

        public void move()
        {
            Console.WriteLine("Fiat move");
        }
    }
}
