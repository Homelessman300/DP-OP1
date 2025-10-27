namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
            boiler.fill();
            boiler.boil();
            boiler.drain();
            ChocolateBoiler anotherBoiler = ChocolateBoiler.GetInstance();
            if (boiler == anotherBoiler)
            {
                Console.WriteLine("Both are the same instance");
            }
        }
    }
}