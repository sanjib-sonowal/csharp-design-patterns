using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Let's consider a scenario where we have different shapes (e.g., Circle, Square) and different 
     * rendering methods (e.g., Raster, Vector). We want to render shapes using different rendering 
     * techniques, and we want to keep the implementation of shapes and rendering methods separate 
     * so that we can mix and match them easily.
    */

    /*Explanation:
     * Abstraction (Shape):
     * The Shape class is the abstraction that uses a renderer to draw the shape.
     * It holds a reference to an implementor (IRenderer) and defines an abstract Draw() method.
     * 
     * Refined Abstraction (Circle, Square):
     * These are concrete shapes that extend the Shape abstraction.
     * They implement the Draw() method to draw the specific shape using the renderer.
     * 
     * Implementor (IRenderer):
     * The IRenderer interface defines the methods for rendering shapes.
     * Different concrete implementations of this interface provide specific rendering techniques.
     * 
     * Concrete Implementor (RasterRenderer, VectorRenderer):
     * These classes implement the IRenderer interface to provide specific rendering methods.
     * For example, RasterRenderer draws shapes using raster techniques, while VectorRenderer uses 
     * vector techniques.
     * 
     * Client (Program):
     * The client creates shapes and assigns them a renderer.
     * The client can change the renderer at runtime without modifying the shape classes.
    */

    // Abstraction
    abstract class Shape2
    {
        protected IRenderer renderer;

        protected Shape2(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }

    // Refined Abstraction
    class Circle2 : Shape2
    {
        private readonly double radius;

        public Circle2(IRenderer renderer, double radius) : base(renderer)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            renderer.RenderCircle(radius);
        }
    }

    // Refined Abstraction
    class Square2 : Shape2
    {
        private readonly double side;

        public Square2(IRenderer renderer, double side) : base(renderer)
        {
            this.side = side;
        }

        public override void Draw()
        {
            renderer.RenderSquare(side);
        }
    }

    // Implementor
    public interface IRenderer
    {
        void RenderCircle(double radius);
        void RenderSquare(double side);
    }

    // Concrete Implementor A
    class RasterRenderer : IRenderer
    {
        public void RenderCircle(double radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using Raster rendering.");
        }

        public void RenderSquare(double side)
        {
            Console.WriteLine($"Drawing a square of side {side} using Raster rendering.");
        }
    }

    // Concrete Implementor B
    class VectorRenderer : IRenderer
    {
        public void RenderCircle(double radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using Vector rendering.");
        }

        public void RenderSquare(double side)
        {
            Console.WriteLine($"Drawing a square of side {side} using Vector rendering.");
        }
    }
}
