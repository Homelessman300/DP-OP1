﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            quackBehavior = new Qauck();
            flyBehavior = new FlyWithWing();
            swimBehavior = new RegularSwim();

        }
        public override void Display()
        {
            Console.WriteLine("I'm a RobotDuck Beep");
        }
    }
}
