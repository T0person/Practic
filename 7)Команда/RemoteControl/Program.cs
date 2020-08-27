using RemoteControl.Commands;
using RemoteControl.Commands.CeilingFanCommands;
using RemoteControl.Commands.GarageCommands;
using RemoteControl.Commands.LightCommands;
using RemoteControl.Commands.StereoCommands;
using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.ComponentModel;
using System.Threading;

namespace RemoteControl
{
    // 6 глава
    // 7 паттерн
    // Команда
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl control = new SimpleRemoteControl();

            // Объекты
            Garage garage = new Garage();
            Stereo stereo = new Stereo();
            CeilingFan ceilingFan = new CeilingFan("BedRoom");

            // Команды над объектами
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garage);
            GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garage);
            
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            // Запоминаем кнопки на пульте
            control.SetCommands(0, garageDoorOpen, garageDoorClose);
            control.SetCommands(1, stereoOnWithCD, stereoOff);
            control.SetCommands(2, ceilingFanMedium, ceilingFanOff);
            control.SetCommands(3, ceilingFanHigh, ceilingFanOff);

            control.OnButtonWasPressed(0);
            Thread.Sleep(1000);
            control.OnButtonWasPressed(1);
            Console.WriteLine("Играет музыка");
            Thread.Sleep(2500);
            control.undoButtonWasPushed();
            Thread.Sleep(1000);
            control.OffButtonWasPressed(0);
            Thread.Sleep(1000);
            control.OnButtonWasPressed(2);
            Thread.Sleep(1000);
            control.OffButtonWasPressed(2);
            Thread.Sleep(1000);
            control.undoButtonWasPushed();
            Thread.Sleep(1000);
            control.OnButtonWasPressed(3);
            Thread.Sleep(1000);
            control.OffButtonWasPressed(3);
            Thread.Sleep(1000);

            Console.WriteLine("---Часть 3---");
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            ICommand[] _partyOn = {garageDoorOpen, lightOn, stereoOnWithCD };
            ICommand[] _partyOff = { garageDoorClose, lightOff, stereoOff };

            MacroCommand macroCommandOn = new MacroCommand(_partyOn);
            MacroCommand macroCommandOff = new MacroCommand(_partyOff);

            control.SetCommands(4, macroCommandOn, macroCommandOff);
            control.OnButtonWasPressed(4);
            Console.WriteLine("Вырубание");
            control.OffButtonWasPressed(4);

        }
    }
}
