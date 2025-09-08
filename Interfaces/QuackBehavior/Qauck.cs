using StrategyPattern.Interfaces.QuackBehavior;
using System;

public class Qauck : QuackBehavior
{

    public void Quack()
    {
        Console.WriteLine("Quack Quack");
    }
}
