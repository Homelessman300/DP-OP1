using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double cost = baseBeverage.cost();

            // Adjust condiment price based on beverage size
            switch (Size)
            {
                case Size.TALL:
                    cost += 0.20;
                    break;
                case Size.GRANDE:
                    cost += 0.40;
                    break;
                case Size.VENDI:
                    cost += 0.50;
                    break;
            }

            return cost;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", milk foam";
        }
    }
}
