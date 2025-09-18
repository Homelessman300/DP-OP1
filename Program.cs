using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Espresso (Tall)
            Beverage espresso = new Espresso { Size = Size.TALL };
            PrintBeverage(espresso);

            // Doppio (Grande)
            Beverage doppio = new Espresso { Size = Size.GRANDE };
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);

            // Lungo (Vendi)
            Beverage lungo = new Espresso { Size = Size.VENDI };
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            // Macchiato (Tall)
            Beverage macchiato = new Espresso { Size = Size.TALL };
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            // Coretta (Tall)
            Beverage coretta = new Espresso { Size = Size.TALL };
            coretta = new Liqour(coretta);
            PrintBeverage(coretta);

            // Con Panna (Tall)
            Beverage conPanna = new Espresso { Size = Size.TALL };
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            // Cappuccino (Grande)
            Beverage cappuccino = new Espresso { Size = Size.GRANDE };
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage(cappuccino);

            // Americano (Vendi)
            Beverage americano = new Espresso { Size = Size.VENDI };
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            // Caffé Latte (Grande)
            Beverage caffeLatte = new Espresso { Size = Size.GRANDE };
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White (Grande)
            Beverage flatWhite = new Espresso { Size = Size.GRANDE };
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            // Romana (Tall)
            Beverage romana = new Espresso { Size = Size.TALL };
            romana = new Lemon(romana);
            PrintBeverage(romana);

            // Marocchino (Tall)
            Beverage marocchino = new Espresso { Size = Size.TALL };
            marocchino = new Chocolate(marocchino);
            marocchino = new MilkFoam(marocchino);
            PrintBeverage(marocchino);

            // Mocha (Grande)
            Beverage mocha = new Espresso { Size = Size.GRANDE };
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            // Bicerin (Grande)
            Beverage bicerin = new Espresso { Size = Size.GRANDE };
            bicerin = new BlackChocolate(bicerin);
            bicerin = new White_Chocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            // Breve (Grande)
            Beverage breve = new Espresso { Size = Size.GRANDE };
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            // Raf coffee (Grande)
            Beverage rafCoffee = new Espresso { Size = Size.GRANDE };
            rafCoffee = new Vanilla_Sugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            // Mead Raf (Grande)
            Beverage meadRaf = new Espresso { Size = Size.GRANDE };
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            // Galao (Grande)
            Beverage galao = new Espresso { Size = Size.GRANDE };
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            // Caffé Affogato (Tall)
            Beverage caffeAffogato = new Espresso { Size = Size.TALL };
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new Ice_cream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            // Vienna Coffee (Grande)
            Beverage viennaCoffee = new Espresso { Size = Size.GRANDE };
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace (Tall)
            Beverage glace = new Espresso { Size = Size.TALL };
            glace = new Ice_cream(glace);
            PrintBeverage(glace);

            // Chocolate Milk (Vendi)
            Beverage chocolateMilk = new Chocolate { Size = Size.VENDI };
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            // Demi-crème (Tall)
            Beverage demiCreme = new Espresso { Size = Size.TALL };
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // Latte Macchiato (Vendi)
            Beverage latteMacchiato = new Espresso { Size = Size.VENDI };
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            // Freddo (Grande)
            Beverage freddo = new Espresso { Size = Size.GRANDE };
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            // Frappuccino (Vendi)
            Beverage frappuccino = new Espresso { Size = Size.VENDI };
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            // Caramel Frappuccino (Vendi)
            Beverage caramelFrappuccino = new Espresso { Size = Size.VENDI };
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // Frappe (Vendi)
            Beverage frappe = new Espresso { Size = Size.VENDI };
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new Ice_cream(frappe);
            PrintBeverage(frappe);

            // Irish Coffee (Grande)
            Beverage irishCoffee = new Espresso { Size = Size.GRANDE };
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.Size} {beverage.GetDescription()} ${beverage.cost():0.##}");
        }
    }
}
