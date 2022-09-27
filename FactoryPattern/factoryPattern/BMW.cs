using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class BMW : ICar
    {
        public string getName()
        {
            return "BMW";
        }

        public void move()
        {
            Console.WriteLine("BMW move");
        }
    }
}
