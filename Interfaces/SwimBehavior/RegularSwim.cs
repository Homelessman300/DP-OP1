using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class RegularSwim : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("SPLASH SPLASH");
        }
    }

