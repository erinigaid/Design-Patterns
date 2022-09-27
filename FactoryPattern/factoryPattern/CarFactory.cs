using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace factoryPattern
{
    class CarFactory
    {
        Dictionary<string, Type> cars = new Dictionary<string, Type>();

        public CarFactory()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where
                (t => typeof(ICar).IsAssignableFrom(t)).ToArray();
            foreach(Type t in types)
            {
                cars.Add(t.Name.ToLower(), t);
            }
        }
        public ICar create(string input)
        {
            if (cars.ContainsKey(input.ToLower()))
                return Activator.CreateInstance(cars[input.ToLower()]) as ICar;
            else
                return new nullCar();
        
        }
    }
}
