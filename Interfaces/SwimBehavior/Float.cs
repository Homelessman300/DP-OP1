using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Float : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm floating on the water");
        }
    }

