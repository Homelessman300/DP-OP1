namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }

    internal abstract class Beverage
    {
        protected string description = "Unknown";
        protected Beverage baseBeverage = null;

        // Default size if nothing is set
        private Size size = Size.TALL;

        public virtual Size Size
        {
            get
            {
                return baseBeverage?.Size ?? size;
            }
            set
            {
                if (baseBeverage != null)
                {
                    baseBeverage.Size = value;
                }
                else
                {
                    size = value;
                }
            }
        }

        public virtual string GetDescription()
        {
            return description;
        }

        protected double GetSizeCost(double baseCost)
        {
            return Size switch
            {
                Size.TALL => baseCost,
                Size.GRANDE => baseCost + 0.50, 
                Size.VENDI => baseCost + 1.00, 
                _ => baseCost
            };
        }

        public abstract double cost();
    }
}   