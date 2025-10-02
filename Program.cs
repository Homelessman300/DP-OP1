using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (name type in Enum.GetValues(typeof(name)))
            {
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    var beverage = BeverageFactory.CreateBeverage(type, size);
                    PrintBeverage(beverage);
                }
            }
        }

        public static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.Size} {beverage.GetDescription()} ${beverage.cost():0.##}");
        }
    }
}
