using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our cafe\nwhat would you like to order?");
            Console.WriteLine("1.Coffee\n2.tea\n3.hot chocolate\n4.turkish coffee\n5.iced coffee");
            int basic = int.Parse(Console.ReadLine());
            double cost=0;
            string description="";
            cafe baverage=null;
            switch (basic)
            {
                case 1:
                    baverage = new BasicCoffee();
                    cost = baverage.getCost();
                    description = baverage.getDescription();
                    break;
                case 2:
                    baverage = new BasicTea();
                    cost = baverage.getCost();
                    description = baverage.getDescription();
                    break;
                case 3:
                    baverage = new BasicHotChocolate();
                    cost = baverage.getCost();
                    description = baverage.getDescription();
                    break;
                case 4:
                    baverage = new BasicTurkishCoffee();
                    cost = baverage.getCost();
                    description = baverage.getDescription();
                    break;
                case 5:
                    baverage = new BasicIcedCoffee();
                    cost = baverage.getCost();
                    description = baverage.getDescription();
                    break;
            }
            Console.WriteLine("Would you like to add any extras to your order?\n1.yes\n2.no");
            int extrachoice = int.Parse(Console.ReadLine());
            if (extrachoice == 1)
                
            {
                Boolean loop = true;
               while (loop==true)
                {
                Console.WriteLine("Choose your extras\n1.Coconut Milk\n2.Almond Milk\n3.Skimmed Milk\n4.Full Fat Milk\n5.final cost");
                int extra = int.Parse(Console.ReadLine());

                    switch (extra)
                    {
                        case 1:
                            CoconutMilk coconutmilk = new CoconutMilk(baverage);
                            cost = coconutmilk.getCost();
                            description = coconutmilk.getDescription();
                            break;
                        case 2:
                            AlmondMilk almondmilk = new AlmondMilk(baverage);
                            cost = almondmilk.getCost();
                            description = almondmilk.getDescription();
                            break;
                        case 3:
                            SkimmedMilk skimmedmilk = new SkimmedMilk(baverage);
                            cost = skimmedmilk.getCost();
                            description = skimmedmilk.getDescription();
                            break;
                        case 4:
                            FullFatMilk fullfatmilk = new FullFatMilk(baverage);
                            cost = fullfatmilk.getCost();
                            description = fullfatmilk.getDescription();
                            break;
                        case 5:
                            Console.WriteLine("you ordered:"+description +"your final cost is: " + cost);
                            loop = false;
                            break;
                    }
                }
            }
            else {
                Console.WriteLine("You ordered"+description+"Your order cost is:"+cost);
            }
        }
        }
  
    }

