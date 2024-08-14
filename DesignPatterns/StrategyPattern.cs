using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * In this example, we'll create a scenario where a PaymentProcessor can use different payment strategies, 
     * such as CreditCardPayment and PayPalPayment.
    */

    /*Explanation:
     * IPaymentStrategy Interface: This interface defines the Pay method, which will be implemented by 
     * different payment strategies.
     * 
     * CreditCardPayment and PayPalPayment Classes: These classes implement the IPaymentStrategy interface, 
     * providing specific implementations for the Pay method.
     * 
     * PaymentProcessor Class (Context): This class uses an instance of IPaymentStrategy to process payments. 
     * The strategy can be set dynamically at runtime using the SetPaymentStrategy method.
     * 
     * Main Program: The PaymentProcessor is used to process payments with different strategies (CreditCardPayment and PayPalPayment). 
     * The payment strategy can be changed dynamically, allowing for flexible payment processing.
    */

    // Step 1: Define the IPaymentStrategy Interface
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }

    // Step 2: Implement Concrete Strategies
    // 1. CreditCardPayment Class
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }

    // 2. PayPalPayment Class
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }

    // Step 3: Create the PaymentProcessor Class(Context)
    public class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;

        // Setting the strategy dynamically
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
