using StrategyPattern.Interfaces.QuackBehavior;
using System;

public class Squeak : QuackBehavior
{

    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
