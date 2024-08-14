using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /* 
     * In this example, we'll create a basic Coffee class and use decorators 
     * to add additional features (like milk and sugar) to the coffee.
    */

    /* Explanation: 
     * Singleton Class: This class contains a private static variable _instance to hold the single instance of the class. 
     * The constructor is private, preventing instantiation from outside the class. 
     * The Instance property provides a global access point to the single instance.
     * 
     * Thread Safety: The lock keyword ensures that only one thread can enter the critical section of the code at a time, 
     * making the singleton thread-safe. The double-check locking mechanism further optimizes performance by avoiding 
     * unnecessary locking after the instance has been created.
     * 
     * Usage: The Singleton.Instance property is used to get the singleton instance. Since only one instance is ever 
     * created, all references to Singleton.Instance will point to the same object in memory.
    */

    // Step 1: Create the Singleton Class.
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        // Private constructor ensures that the class cannot be instantiated from outside.
        private Singleton()
        {
            // Initialization code (if needed)
        }

        // Public method to provide a global point of access to the instance.
        public static Singleton Instance
        {
            get
            {
                // Double-check locking mechanism to ensure thread safety.
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        // An example method that can be accessed through the singleton instance.
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something!");
        }
    }

}
