using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            // Vendor Classes 
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(new Light("Garagedoor"));
            Stereo stereo = new Stereo();
            

            // Command Objects 
            // Lights
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            // Ceiling Fan
            CycleCeilingFanCommand ceilingFan =  new CycleCeilingFanCommand (livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);

            // Garage Door
            GarageDoorUpCommand garageDoorOpen = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorClose = new GarageDoorDownCommand(garageDoor);

            // Stereo
            StereoOnWithCdCommand stereoOn = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            // Assign Commands to RemoteControl Slots
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFan, ceilingFanOff);
            remoteControl.SetCommand(3, garageDoorOpen, garageDoorClose);
            remoteControl.SetCommand(4, stereoOn, stereoOff);

            // Print the remote layout
            Console.WriteLine(remoteControl);

            // Test Buttons 
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            remoteControl.OffButtonWasPushed(2);

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);

            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);    
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.ReadKey();
        }
    }
}
