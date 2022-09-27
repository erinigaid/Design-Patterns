using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class Lancer : ICar
    {
        public string getName()
        {
            return "Lancer";
        }

        public void move()
        {
            Console.WriteLine("Lancer move");
        }
    }
}
