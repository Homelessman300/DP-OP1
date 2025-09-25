using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeveragePrint.PrintAllBeverages();
        }

        public static void PrintBeverage(Beverages.Beverage beverage)
        {
            Console.WriteLine($"{beverage.Size} {beverage.GetDescription()} ${beverage.cost():0.##}");
        }
    }
}
