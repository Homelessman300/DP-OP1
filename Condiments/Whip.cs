using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
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
                    cost += 0.30;
                    break;
                case Size.VENDI:
                    cost += 0.40;
                    break;
            }

            return cost;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Whip";
        }
    }
}
