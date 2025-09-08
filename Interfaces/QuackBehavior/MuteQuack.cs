using StrategyPattern.Interfaces.QuackBehavior;
using System;

public class MuteQuack : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}
