using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * In this example, we'll create a scenario where a RemoteControl can execute different commands 
     * like turning a light on or off.
    */

    /*Explanation:
     * ICommand Interface: This interface defines the Execute method, which will be implemented by concrete command classes.
     * 
     * Concrete Command Classes (LightOnCommand and LightOffCommand): These classes implement the ICommand interface 
     * and encapsulate the action of turning the light on or off.
     * 
     * Light Class (Receiver): This class contains the actual logic for turning the light on and off.
     * 
     * RemoteControl Class (Invoker): This class is responsible for executing commands. It holds a reference to an 
     * ICommand object and calls its Execute method when the button is pressed.
     * 
     * Main Program: The RemoteControl object is used to execute different commands (LightOnCommand and LightOffCommand) 
     * by setting the command and pressing the button. The commands control the light (receiver) by turning it on or off.
    */

    // Step 1: Define the ICommand Interface
    public interface ICommand
    {
        void Execute();
    }

    // Step 2: Implement Concrete Commands
    // 1. LightOnCommand Class
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }

    // 2. LightOffCommand Class
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }

    // Step 3: Create the Light Class (Receiver)
    public class Light
    {
        public void On()
        {
            Console.WriteLine("The light is on.");
        }

        public void Off()
        {
            Console.WriteLine("The light is off.");
        }
    }

    // Step 4: Create the RemoteControl Class (Invoker)
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
