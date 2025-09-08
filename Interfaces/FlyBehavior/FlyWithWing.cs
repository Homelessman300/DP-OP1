using StrategyPattern.Interfaces.FlyBehavior;
using System;

public class FlyWithWing : FlyBehavior
{


    public void Fly()
    {
        Console.WriteLine("I can fly with my wings!");
    }
}
