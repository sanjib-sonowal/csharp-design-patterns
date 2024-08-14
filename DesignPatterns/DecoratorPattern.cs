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
     * ICoffee Interface: Defines the methods GetDescription and GetCost that all coffee objects must implement.
     * 
     * SimpleCoffee Class: A basic implementation of ICoffee representing a plain coffee.
     * 
     * CoffeeDecorator Abstract Class: Implements ICoffee and holds a reference to a ICoffee object. 
     * It provides a base for all concrete decorators.
     * 
     * Concrete Decorators (MilkDecorator and SugarDecorator): Extend the CoffeeDecorator class and modify 
     * the behavior of GetDescription and GetCost to add milk and sugar respectively.
     * 
     * Main Program: A SimpleCoffee object is decorated with MilkDecorator and SugarDecorator. 
     * Each decorator modifies the description and cost of the coffee, showing how the Decorator pattern allows 
     * for flexible addition of responsibilities to objects.
    */

    // Step 1: Define the ICoffee Interface
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    // Step 2: Implement the Basic Coffee Class
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 2.00; // Base cost of the coffee
        }
    }

    // Step 3: Create the CoffeeDecorator Abstract Class
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }
    }

    // Step 4: Implement Concrete Decorators(e.g., MilkDecorator and SugarDecorator)
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.50; // Cost of milk
        }
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.20; // Cost of sugar
        }
    }
}
