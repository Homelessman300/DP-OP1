using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factory
{
    internal static class BeverageFactoryProvider
    {
        public static Beverage CreateBeverage(string name, Size size)
        {
            return name switch
            {
                "Espresso" => new EspressoFactory().Create(size),
                "Doppio" => new DoppioFactory().Create(size),
                "Lungo" => new LungoFactory().Create(size),
                "Macchiato" => new MacchiatoFactory().Create(size),
                "Corretta" => new CorrettaFactory().Create(size),
                "ConPanna" => new ConPannaFactory().Create(size),
                "Cappuccino" => new CappuccinoFactory().Create(size),
                "Americano" => new AmericanoFactory().Create(size),
                "CaffeLatte" => new CaffeLatteFactory().Create(size),
                "FlatWhite" => new FlatWhiteFactory().Create(size),
                "Romana" => new RomanaFactory().Create(size),
                "Morocchino" => new MorocchinoFactory().Create(size),
                "Mocha" => new MochaFactory().Create(size),
                "Bicerin" => new BicerinFactory().Create(size),
                "Breve" => new BreveFactory().Create(size),
                "RafCoffee" => new RafCoffeeFactory().Create(size),
                "MeadRaf" => new MeadRafFactory().Create(size),
                "Galao" => new GalaoFactory().Create(size),
                "CaffeAffogato" => new CaffeAffogatoFactory().Create(size),
                "ViennaCoffee" => new ViennaCoffeeFactory().Create(size),
                "Glace" => new GlaceFactory().Create(size),
                "ChocolateMilk" => new ChocolateMilkFactory().Create(size),
                "DemiCreme" => new DemiCremeFactory().Create(size),
                "LatteMacchiato" => new LatteMacchiatoFactory().Create(size),
                "Freddo" => new FreddoFactory().Create(size),
                "Frappuccino" => new FrappuccinoFactory().Create(size),
                "CaramelFrappuccino" => new CaramelFrappuccinoFactory().Create(size),
                "Frappe" => new FrappeFactory().Create(size),
                "IrishCoffee" => new IrishCoffeeFactory().Create(size),
                _ => throw new ArgumentOutOfRangeException(nameof(name), "Unknown beverage")
            };
        }
    }
}