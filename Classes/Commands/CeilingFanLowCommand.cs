using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanLowCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Low();
            if (ceilingFan.GetSpeed() == ceilingFan.HIGH)
            {
                prevSpeed = ceilingFan.LOW;
            }
            else if (ceilingFan.GetSpeed() == ceilingFan.MEDIUM)
            {
                prevSpeed = ceilingFan.HIGH;
            }
            else if (ceilingFan.GetSpeed() == ceilingFan.LOW)
            {
                prevSpeed = ceilingFan.MEDIUM;
            }

        }

        public void Undo()
        {
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == ceilingFan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
