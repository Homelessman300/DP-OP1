namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton boiler = Singleton.GetInstance();
            boiler.fill();
            boiler.boil();
            boiler.drain();
            Singleton anotherBoiler = Singleton.GetInstance();
            if (boiler == anotherBoiler)
            {
                Console.WriteLine("Both are the same instance");
            }
        }
    }
}