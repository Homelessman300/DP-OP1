﻿using System;
using StrategyPattern.Interfaces.FlyBehavior;

public class FlyNoWay : FlyBehavior
{
	
    public void Fly()
    {
        Console.WriteLine("I can't fly for shit");
    }
}
