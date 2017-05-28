using CommandPatternTutorial.ConcreteCommand;
using CommandPatternTutorial.Invoker;
using CommandPatternTutorial.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Existing stuff in the house
            Light light = new Light();
            AirConditioner airConditioner = new AirConditioner();

            // Create the On Commands
            LightOn turnOnLight = new LightOn(light);
            AirConditionerOn turnOnAC = new AirConditionerOn(airConditioner);

            // Create the Off Commands
            LightOff turnOffLight = new LightOff(light);
            AirConditionerOff turnOffAC = new AirConditionerOff(airConditioner);

            // Program remote controller
            RemoteController remote = new RemoteController();
            remote.InsertNewOnCommand(turnOnLight);
            remote.InsertNewOnCommand(turnOnAC);
            remote.InsertNewOffCommand(turnOffLight);
            remote.InsertNewOffCommand(turnOffAC);

            // Test buttons: Turn On the lights and AC
            remote.PressButtonOn(0);
            remote.PressButtonOn(1);

            // Test buttons: Turn Off the lights and AC
            remote.PressButtonOff(0);
            remote.PressButtonOff(1);


            Console.ReadLine();
        }
    }
}
