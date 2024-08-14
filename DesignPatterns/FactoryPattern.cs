using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /* 
     * In this example, we'll create a factory that creates different types of 
     * shapes (e.g., Circle, Square, and Rectangle).
    */

    /*Explanation:
     * IShape Interface: This defines the contract for the Draw method.
     * 
     * Concrete Classes (Circle, Square, Rectangle): These classes implement the IShape interface.
     * 
     * ShapeFactory: This factory class contains a method GetShape that takes a string as an argument and returns 
     * an instance of the appropriate shape class.
     * 
     * Main Program: The factory is used to create objects without exposing the creation logic to the client, 
     * and the client interacts with the object through the interface.
    */

    // Step 1: Define the IShape interface.
    public interface IShape
    {
        void Draw();
    }

    // Step 2: Implement the IShape interface in different classes.
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Square.");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    // Step 3: Create a Factory class to generate objects of concrete classes.
    public class ShapeFactory
    {
        public IShape? GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                return null;
            }

            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                case "square":
                    return new Square();
                case "rectangle":
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }

}
