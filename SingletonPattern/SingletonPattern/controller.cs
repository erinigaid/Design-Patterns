using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class controller
    {
        public static object obj = new object();
        private static controller c;
        private controller() {
            Console.WriteLine("the temperature reached 300");
        
        }

        public static controller getter
        {
            get
            {
                if (c == null)
                {
                    lock (obj)
                    {
                        if (c == null)
                            c = new controller();
                    }
                }


                return c;
            }
        }
    }
}
