namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        private volatile static ChocolateBoiler instance;

        private static readonly object LockObject = new object();

        // Private constructor voorkomt dat anderen een instantie maken
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        // This code is only started when the boiler is empty
        public static ChocolateBoiler GetInstance()
        {
            if (instance == null)
            {
                lock (LockObject)
                {
                    if (instance == null)
                    {
                        instance = new ChocolateBoiler();
                    }
                }
            }
            return instance;
        }

        // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Filling the boiler with mixture");
            }
        }

        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                Console.WriteLine("Draining the boiled mixture");
            }
        }

        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("Boiling the mixture");
            }
        }
    }
}
