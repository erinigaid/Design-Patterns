using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class TurkeyAdapter : IDuck
    {
          ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }
        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                turkey.Fly();
                Console.WriteLine("Resting..");
            }
        }
    }
}