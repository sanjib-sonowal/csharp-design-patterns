using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /* 
     * We'll create a scenario where we want to build a House with different components like walls, doors, 
     * and windows. The HouseBuilder will allow us to construct a house step by step.
    */

    /*Explanation:
     * House Class: Represents the complex object that is being built. It contains properties like Walls, Doors, and Windows.
     * 
     * IHouseBuilder Interface: Declares the methods for building different parts of the House.
     * 
     * ConcreteHouseBuilder Class: Implements the IHouseBuilder interface and provides the specific logic for building the House.
     * 
     * HouseDirector Class: The Director controls the construction process using the builder. It can build different 
     * configurations of the house.
     * 
     * Main Program: The HouseDirector constructs different types of houses (simple and luxury) using the 
     * ConcreteHouseBuilder. Each type of house is constructed step by step, and the result is printed.
    */

    // Step 1: Define the House Class
    public class House
    {
        public int Walls { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }

        public override string ToString()
        {
            return $"House with {Walls} walls, {Doors} doors, and {Windows} windows.";
        }
    }

    // Step 2: Create the HouseBuilder Interface
    public interface IHouseBuilder
    {
        void BuildWalls(int numberOfWalls);
        void BuildDoors(int numberOfDoors);
        void BuildWindows(int numberOfWindows);
        House GetHouse();
    }

    // Step 3: Implement the Concrete HouseBuilder
    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildWalls(int numberOfWalls)
        {
            _house.Walls = numberOfWalls;
        }

        public void BuildDoors(int numberOfDoors)
        {
            _house.Doors = numberOfDoors;
        }

        public void BuildWindows(int numberOfWindows)
        {
            _house.Windows = numberOfWindows;
        }

        public House GetHouse()
        {
            return _house;
        }
    }

    // Step 4: Create the Director Class
    // The Director class controls the construction process. It uses a builder to create a specific configuration of the House.
    public class HouseDirector
    {
        private IHouseBuilder _builder;

        public HouseDirector(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructSimpleHouse()
        {
            _builder.BuildWalls(4);
            _builder.BuildDoors(1);
            _builder.BuildWindows(2);
        }

        public void ConstructLuxuryHouse()
        {
            _builder.BuildWalls(10);
            _builder.BuildDoors(5);
            _builder.BuildWindows(8);
        }
    }
}
