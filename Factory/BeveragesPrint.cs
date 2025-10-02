using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{
    public enum BeverageType
    {
        Espresso,
        Doppio,
        Lungo,
        Macchiato,
        Corretta,
        ConPanna,
        Cappuccino,
        Americano,
        CaffeLatte,
        FlatWhite,
        Romana,
        Morocchino,
        Mocha,
        Bicerin,
        Breve,
        RafCoffee,
        MeadRaf,
        Galao,
        CaffeAffogato,
        ViennaCoffee,
        Glace,
        ChocolateMilk,
        DemiCreme,
        LatteMacchiato,
        Freddo,
        Frappuccino,
        CaramelFrappuccino,
        Frappe,
        IrishCoffee
    }

    // -------- Abstract Factory --------
    public abstract class BeverageFactory
    {
        public abstract Beverage Create(Size size);
    }

    // -------- Concrete Factories --------
    public class EspressoFactory : BeverageFactory
    {
        public override Beverage Create(Size size) => new Espresso(size);
    }

    public class DoppioFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Espresso(b); // double espresso
            return b;
        }
    }

    public class LungoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Water(b);
            return b;
        }
    }

    public class MacchiatoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new MilkFoam(b);
            return b;
        }
    }

    public class CorrettaFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Liqour(b);
            return b;
        }
    }

    public class ConPannaFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Whip(b);
            return b;
        }
    }

    public class CappuccinoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new SteamedMilk(b);
            b = new MilkFoam(b);
            return b;
        }
    }

    public class AmericanoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Water(b);
            b = new Water(b);
            return b;
        }
    }

    public class CaffeLatteFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new SteamedMilk(b);
            b = new SteamedMilk(b);
            b = new MilkFoam(b);
            return b;
        }
    }

    public class FlatWhiteFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new SteamedMilk(b);
            b = new SteamedMilk(b);
            return b;
        }
    }

    public class RomanaFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Lemon(b);
            return b;
        }
    }

    public class MorocchinoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Chocolate(b);
            b = new MilkFoam(b);
            return b;
        }
    }

    public class MochaFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Chocolate(b);
            b = new SteamedMilk(b);
            b = new Whip(b);
            return b;
        }
    }

    public class BicerinFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new BlackChocolate(b);
            b = new White_Chocolate(b);
            b = new Whip(b);
            return b;
        }
    }

    public class BreveFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new MilkFoam(b);
            b = new HalfMilk(b);
            return b;
        }
    }

    public class RafCoffeeFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Vanilla_Sugar(b);
            b = new Sugar(b);
            b = new Cream(b);
            return b;
        }
    }

    public class MeadRafFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Honey(b);
            b = new Cream(b);
            return b;
        }
    }

    public class GalaoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new MilkFoam(b);
            b = new MilkFoam(b);
            return b;
        }
    }

    public class CaffeAffogatoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Espresso(b);
            b = new IceCream(b);
            return b;
        }
    }

    public class ViennaCoffeeFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Espresso(b);
            b = new Whip(b);
            b = new Whip(b);
            return b;
        }
    }

    public class GlaceFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new IceCream(b);
            return b;
        }
    }

    public class ChocolateMilkFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Chocolate(size);
            b = new Milk(b);
            b = new Milk(b);
            return b;
        }
    }

    public class DemiCremeFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Espresso(b);
            b = new Cream(b);
            b = new Cream(b);
            return b;
        }
    }

    public class LatteMacchiatoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new SteamedMilk(b);
            b = new SteamedMilk(b);
            b = new MilkFoam(b);
            return b;
        }
    }

    public class FreddoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Liqour(b);
            b = new Ice(b);
            return b;
        }
    }

    public class FrappuccinoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Ice(b);
            b = new SteamedMilk(b);
            b = new Whip(b);
            return b;
        }
    }

    public class CaramelFrappuccinoFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Ice(b);
            b = new SteamedMilk(b);
            b = new Cream(b);
            b = new Syrup(b);
            return b;
        }
    }

    public class FrappeFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new SteamedMilk(b);
            b = new SteamedMilk(b);
            b = new Ice_cream(b);
            return b;
        }
    }

    public class IrishCoffeeFactory : BeverageFactory
    {
        public override Beverage Create(Size size)
        {
            Beverage b = new Espresso(size);
            b = new Espresso(b);
            b = new Whiskey(b);
            b = new Whip(b);
            return b;
        }
    }
}
