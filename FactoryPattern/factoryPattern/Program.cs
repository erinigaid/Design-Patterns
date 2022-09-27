using System;

namespace factoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar a = createCar("BMW");
            a.move();

            CarFactory cf = new CarFactory();

            ICar BMWCar = cf.create("BMW");
            BMWCar.move();

            ICar lancer = cf.create("lancer");
            lancer.move();
        }

        
        
        
        
        
        
        
        
        
        public static ICar createCar(string carType)
        {
            switch (carType)
            {
                case ("KIA"):
                    return new KIA();
                    break;
                case ("Fiat"):
                    return new Fiat();
                    break;
                case ("BMW"):
                    return new BMW();
                    break;

                default:
                    return new nullCar();
            }
        }
    }
}
