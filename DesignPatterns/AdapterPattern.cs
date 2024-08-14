using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /* 
     * In this example, we'll create a scenario where a ITarget interface is expected by a client, 
     * but an incompatible class Adaptee needs to be used. We'll use an Adapter class to bridge the gap 
     * between the ITarget interface and the Adaptee class.
    */

    /*Explanation:
     * ITarget Interface: This is the interface that the client expects. It defines a method GetRequest.
     * 
     * Adaptee Class: This is a class with an incompatible interface that needs to be adapted. 
     * It has a method GetSpecificRequest that doesn't match the ITarget interface.
     * 
     * Adapter Class: This class implements the ITarget interface and adapts the Adaptee class to it. 
     * The GetRequest method in Adapter calls GetSpecificRequest on the Adaptee object and adapts its result 
     * to fit the ITarget interface.
     * 
     * Main Program: The Adapter is used to adapt the Adaptee to the ITarget interface, allowing the client to 
     * work with it as if it were a ITarget object.
    */

    // Step 1: Define the ITarget Interface
    public interface ITarget
    {
        string GetRequest();
    }

    // Step 2: Implement the Adaptee Class (Incompatible Interface)
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request from Adaptee";
        }
    }

    // Step 3: Create the Adapter Class
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            // Adapting the incompatible method to the expected interface
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }
}
