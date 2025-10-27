using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Classes.Commands
{
    internal class CycleCeilingFanCommand : Command
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CycleCeilingFanCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();

            // Cycle to the next state
            switch (prevSpeed)
            {
                case 0: // OFF → LOW
                    ceilingFan.Low();
                    break;
                case 1: // LOW → MEDIUM
                    ceilingFan.Medium();
                    break;
                case 2: // MEDIUM → HIGH
                    ceilingFan.High();
                    break;
                case 3: // HIGH → OFF
                default:
                    ceilingFan.Off();
                    break;
            }
        }

        public void Undo()
        {
            // Return to the previous state
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.High();
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
