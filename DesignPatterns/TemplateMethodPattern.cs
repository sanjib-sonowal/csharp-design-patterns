using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Imagine you are developing a system where different types of data processors (e.g., XML and JSON) 
     * need to follow a common algorithm to process data. However, the way each processor reads and parses 
     * data may vary. The Template Method pattern allows you to define the common algorithm while letting 
     * subclasses implement the specific steps.
    */

    /*Explanation:
     * Abstract Class (DataProcessor):
     * This abstract class defines the ProcessData() method, which is the template method that outlines the steps of the algorithm.
     * It has abstract methods ReadData() and ParseData() that must be implemented by subclasses.
     * The ProcessParsedData() and SaveData() methods are shared by all subclasses and provide common functionality.
     * 
     * Concrete Classes (XMLDataProcessor, JSONDataProcessor):
     * These classes extend DataProcessor and implement the specific steps for reading and parsing data.
     * For example, XMLDataProcessor handles XML data, while JSONDataProcessor handles JSON data.
     * 
     * Client (Program):
     * The client code creates instances of XMLDataProcessor and JSONDataProcessor.
     * It calls the ProcessData() method, which executes the predefined algorithm while allowing the specific steps to be customized by each subclass.
    */

    // Abstract class defining the template method
    abstract class DataProcessor
    {
        // Template method defining the skeleton of the algorithm
        public void ProcessData()
        {
            ReadData();
            ParseData();
            ProcessParsedData();
            SaveData();
        }

        // Steps of the algorithm
        protected abstract void ReadData();
        protected abstract void ParseData();

        // Common methods that can be shared among subclasses
        private void ProcessParsedData()
        {
            Console.WriteLine("Processing parsed data...");
        }

        private void SaveData()
        {
            Console.WriteLine("Saving data to the database...");
        }
    }

    // Concrete class implementing specific steps for XML data
    class XMLDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading XML data from file...");
        }

        protected override void ParseData()
        {
            Console.WriteLine("Parsing XML data...");
        }
    }

    // Concrete class implementing specific steps for JSON data
    class JSONDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading JSON data from file...");
        }

        protected override void ParseData()
        {
            Console.WriteLine("Parsing JSON data...");
        }
    }
}
