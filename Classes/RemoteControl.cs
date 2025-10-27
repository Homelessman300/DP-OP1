using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        Command[] onCommands = new Command[7];
        Command[] offCommands = new Command[7];
        Stack<Command> undoHistory = new Stack<Command>();
        // Stack to store executed commands for multiple undos

        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        // This method must set the On and Off command to the slot provided
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        // This method must call the OnCommand.Execute() method of the slot provided
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            // Push the command instance for undo
            undoHistory.Push(onCommands[slot]);
        }

        // This method must call the OffCommand.Execute() method of the slot provided
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoHistory.Push(offCommands[slot]);
        }

        // This method must call the Undo() method of the last executed command
        public void UndoButtonWasPushed()
        {
            if (undoHistory.Count > 0)
            {
                Command lastCommand = undoHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        // Overwritten ToString() to print out each slot and its corresponding command.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                          + "\t" + offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
