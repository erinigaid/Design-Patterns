using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class KIA : ICar
    {
        public String getName()
        {
            return "KIA";
        }

        public void move()
        {
            Console.WriteLine("KIA move");
        }
    }
}
