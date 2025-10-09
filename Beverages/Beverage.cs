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

        // Size property with getter and setter
        public virtual Size Size
        {
            get
            {
                // If wrapped, inherit size from base beverage
                return baseBeverage?.Size ?? size;
            }
            set
            {
                // If wrapped, propagate size change to base beverage
                // Otherwise, set local size
                if (baseBeverage != null)
                {
                    baseBeverage.Size = value;
                }
                else
                {
                    // Set local size
                    size = value;
                }
            }
        }


        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}