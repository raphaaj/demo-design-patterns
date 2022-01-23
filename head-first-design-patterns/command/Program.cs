using command.Commands;
using command.Devices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Simple Remote
            SimpleRemoteControl remote = new SimpleRemoteControl();

            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();
            */


            /* Remote Control with slots and Undo Button
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light();
            Light kitchenLight = new Light();
            CeilingFan ceilingFan = new CeilingFan();
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo();

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomlLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomlLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, garageDoorOpen, garageDoorClose);
            remoteControl.SetCommand(4, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            for (int i = 0; i < 5; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                remoteControl.UndoButtonWasPushed();
                remoteControl.OffButtonWasPushed(i);
                remoteControl.UndoButtonWasPushed();
            }
            */

            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light();
            Stereo stereo = new Stereo();

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomlLightOff = new LightOffCommand(livingRoomLight);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            MacroCommand partyOnMacro = new MacroCommand(new List<ICommand>() { livingRoomLightOn, stereoOnWithCD });
            MacroCommand partyOffMacro = new MacroCommand(new List<ICommand>() { livingRoomlLightOff, stereoOff });

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            remoteControl.OnButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);


        }
    }
}
