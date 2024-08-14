using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Cloning a Shape: We'll create a scenario where we have a Shape class, and we want to create copies 
     * of different shapes (like circles and rectangles) using the Prototype pattern.
    */

    /*Explanation:
     * IPrototype<T> Interface: Defines a Clone method that returns a copy of the object.
     * 
     * Shape Abstract Class: Implements the IPrototype interface and provides a basic property (Color) that will 
     * be shared among different shapes.
     * 
     * Concrete Shape Classes (Circle and Rectangle): These classes implement the Clone method to create copies 
     * of themselves, including their specific properties like Radius, Width, and Height.
     * 
     * Main Program: The program creates an original Circle and Rectangle, clones them, and modifies the cloned 
     * objects. This demonstrates how the Prototype pattern allows for easy copying and customization of objects.
     * 
     * The Prototype pattern is particularly useful when creating objects is costly, and you need to create 
     * multiple instances with slightly different states. By cloning an existing object, you can quickly 
     * create a new instance without going through the full creation process.
    */

    // Step 1: Define the ICloneable Interface
    // C# has a built-in ICloneable interface, but for clarity, we will define our own interface:
    public interface IPrototype<T>
    {
        T Clone();
    }

    // Step 2: Create the Shape Abstract Class
    public abstract class Shape : IPrototype<Shape>
    {
        public string Color { get; set; }

        public abstract Shape Clone();

        public override string ToString()
        {
            return $"Shape with color: {Color}";
        }
    }

    // Step 3: Implement Concrete Shape Classes
    // 1. Circle Class
    public class Circle1 : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return new Circle1 { Color = this.Color, Radius = this.Radius };
        }

        public override string ToString()
        {
            return $"Circle with color: {Color}, radius: {Radius}";
        }
    }

    // 2. Rectangle Class
    public class Rectangle1 : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override Shape Clone()
        {
            return new Rectangle1 { Color = this.Color, Width = this.Width, Height = this.Height };
        }

        public override string ToString()
        {
            return $"Rectangle with color: {Color}, width: {Width}, height: {Height}";
        }
    }

}
