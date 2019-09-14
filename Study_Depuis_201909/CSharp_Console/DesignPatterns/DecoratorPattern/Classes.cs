using CSharp_Console.GlobalInterface;
using System;

namespace DesignPattern.DecoratorPattern
{
    public class Decorator : IExampleRun
    {
        public void RunExample()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + "$" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.getDescription() + "$" + beverage2.Cost());
        }
    }
    public abstract class Beverage 
    {
        protected string description = "Empty";

        public string getDescription()
        {
            return description;
        }

        public abstract double Cost();


    }

    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.getDescription() + ", 모카";
        }

        public override double Cost()
        {
             return 0.2 + beverage.Cost();
        }
    }

}
