using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Classes.Commands
{
    internal class CycleCeilingFanCommand : Command
    {
        private readonly CeilingFan ceilingFan;

        // Stack to keep track of previous speeds for multiple undos
        private Stack<int> history = new Stack<int>();

        public CycleCeilingFanCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            int prevSpeed = ceilingFan.GetSpeed();
            history.Push(prevSpeed);

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
            if (history.Count > 0)
            {
                int prevSpeed = history.Pop();

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
            else
            {
                Console.WriteLine("Nothing to undo for ceiling fan.");
            }
        }
    }
}
