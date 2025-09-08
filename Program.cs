using StrategyPattern.Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            Console.WriteLine("Select a duck to see:");
            Console.WriteLine("1 - Mallard Duck");
            Console.WriteLine("2 - Redhead Duck");
            Console.WriteLine("3 - Decoy Duck");
            Console.WriteLine("4 - Rubber Duck");
            Console.WriteLine("5 - Robot Duck");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            Duck selectedDuck;

            switch (input)
            {
                case "1": selectedDuck = mallardDuck; break;
                case "2": selectedDuck = redheadDuck; break;
                case "3": selectedDuck = decoyDuck; break;
                case "4": selectedDuck = rubberDuck; break;
                case "5": selectedDuck = robotDuck; break;
                default:
                    Console.WriteLine("Invalid choice! Defaulting to Mallard Duck.");
                    selectedDuck = mallardDuck;
                    break;
            }

            // Standaard gedrag
            Console.WriteLine("\n--- Default behavior ---");
            selectedDuck.Display();
            selectedDuck.PerformQuack();
            selectedDuck.PerformFly();

            // Dynamisch gedrag aanpassen
            Console.WriteLine("\n--- Changing behaviors dynamically ---");
            selectedDuck.SetQuackBehavior(new MuteQuack());   // Stel in dat de eend stil is
            selectedDuck.SetFlyBehavior(new FlyNoWay());// Geef de eend raketkracht

            selectedDuck.PerformQuack(); // -> moet nu niets/anders doen
            selectedDuck.PerformFly();   // -> moet nu raket vliegen doen

            Console.ReadLine();
        }
    }
}
