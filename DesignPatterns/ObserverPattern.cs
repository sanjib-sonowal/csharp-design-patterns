using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /* 
     * In this example, we'll create a subject (Stock) that notifies its observers (Investor) 
     * whenever its state (e.g., stock price) changes.
    */

    /*Explanation:
     * IObserver Interface: This interface defines the Update method, which is called when the subject's state changes.
     * 
     * ISubject Interface: This interface defines methods for registering, removing, and notifying observers.
     * 
     * Stock Class: This class represents the subject being observed. It holds a list of observers and notifies 
     * them whenever its Price property changes.
     * 
     * Investor Class: This class represents an observer. It implements the IObserver interface and reacts to 
     * changes in the Stock class.
     * 
     * Main Program: The appleStock object is created, and two investors are registered as observers. 
     * When the stock price changes, all registered observers are notified. When an observer is removed, 
     * it no longer receives updates.
    */

    // Step 1: Define the IObserver Interface
    public interface IObserver
    {
        void Update(string stockSymbol, double price);
    }

    // Step 2: Define the ISubject Interface
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    // Step 3: Implement the Stock Class (Subject)
    public class Stock : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _symbol;
        private double _price;

        public Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public string Symbol
        {
            get { return _symbol; }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_symbol, _price);
            }
        }
    }

    // Step 4: Implement the Investor Class(Observer)
    public class Investor : IObserver
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(string stockSymbol, double price)
        {
            Console.WriteLine($"Notified {_name} of {stockSymbol}'s price change to {price:C}");
        }
    }
}
