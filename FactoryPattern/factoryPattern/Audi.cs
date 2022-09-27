using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class Audi : ICar
    {
        public string getName()
        {
            return "Audi";
        }

        public void move()
        {
            Console.WriteLine("Audi move");
        }
    }
}
