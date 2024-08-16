using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Let's assume we have a UI toolkit that supports multiple themes (e.g., "Light Theme" and "Dark Theme"). 
     * Each theme has its own set of UI components like buttons and textboxes. We want to create these components 
     * using an abstract factory pattern.
    */

    /*Explanation:
     * Abstract Products (IButton and ITextBox): Define the interface for different types of products.
     * 
     * Concrete Products (LightButton, LightTextBox, DarkButton, DarkTextBox): Implement the abstract product 
     * interfaces for different themes.
     * 
     * Abstract Factory (IUIFactory): Declares methods for creating abstract products.
     * 
     * Concrete Factories (LightThemeFactory, DarkThemeFactory): Implement the abstract factory interface 
     * to create concrete products for specific themes.
     * 
     * Client (Client): The client uses the factory to create and use products. It is unaware of the specific 
     * classes of products it gets.
    */

    // Abstract Product A
    public interface IButton
    {
        void Render();
    }

    // Abstract Product B
    public interface ITextBox
    {
        void Render();
    }

    // Concrete Product A1
    public class LightButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a light-themed button.");
        }
    }

    // Concrete Product B1
    public class LightTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a light-themed textbox.");
        }
    }

    // Concrete Product A2
    public class DarkButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a dark-themed button.");
        }
    }

    // Concrete Product B2
    public class DarkTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a dark-themed textbox.");
        }
    }

    // Abstract Factory
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }

    // Concrete Factory 1
    public class LightThemeFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ITextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }

    // Concrete Factory 2
    public class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ITextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }

    // Client
    class Client
    {
        private readonly IButton _button;
        private readonly ITextBox _textBox;

        public Client(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _textBox = factory.CreateTextBox();
        }

        public void RenderUI()
        {
            _button.Render();
            _textBox.Render();
        }
    }
}
