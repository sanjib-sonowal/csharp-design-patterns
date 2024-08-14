﻿using DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        // Creational Patterns

        #region Singleton Pattern
        // Get the single instance of the Singleton class.
        Singleton singleton1 = Singleton.Instance;
        singleton1.DoSomething();

        // Try to get another instance.
        Singleton singleton2 = Singleton.Instance;
        singleton2.DoSomething();

        // Check if both references point to the same instance.
        Console.WriteLine("Executing Singleton Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        if (singleton1 == singleton2)
        {
            Console.WriteLine("Both references point to the same instance.");
        }
        else
        {
            Console.WriteLine("Different instances exist!");
        }
        Console.WriteLine();
        #endregion

        #region Factory Pattern
        Console.WriteLine("Executing Factory Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        ShapeFactory shapeFactory = new ShapeFactory();

        // Get an object of Circle and call its Draw method.
        IShape shape1 = shapeFactory.GetShape("circle");
        shape1?.Draw();

        // Get an object of Square and call its Draw method.
        IShape shape2 = shapeFactory.GetShape("square");
        shape2?.Draw();

        // Get an object of Rectangle and call its Draw method.
        IShape shape3 = shapeFactory.GetShape("rectangle");
        shape3?.Draw();
        Console.WriteLine();
        #endregion

        #region Builder Pattern
        Console.WriteLine("Executing Builder Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        IHouseBuilder builder = new ConcreteHouseBuilder();
        HouseDirector director = new HouseDirector(builder);

        // Build a simple house
        director.ConstructSimpleHouse();
        House simpleHouse = builder.GetHouse();
        Console.WriteLine(simpleHouse);

        // Build a luxury house
        builder = new ConcreteHouseBuilder(); // Reset the builder
        director = new HouseDirector(builder);
        director.ConstructLuxuryHouse();
        House luxuryHouse = builder.GetHouse();
        Console.WriteLine(luxuryHouse);
        Console.WriteLine();
        #endregion

        #region Prototype Pattern
        Console.WriteLine("Executing Prototype Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // Create an original Circle
        Circle1 originalCircle = new Circle1 { Color = "Red", Radius = 10 };
        Console.WriteLine("Original: " + originalCircle);

        // Clone the Circle
        Circle1 clonedCircle = (Circle1)originalCircle.Clone();
        clonedCircle.Color = "Blue"; // Change the color of the cloned circle
        Console.WriteLine("Cloned: " + clonedCircle);

        // Create an original Rectangle
        Rectangle1 originalRectangle = new Rectangle1 { Color = "Green", Width = 20, Height = 15 };
        Console.WriteLine("Original: " + originalRectangle);

        // Clone the Rectangle
        Rectangle1 clonedRectangle = (Rectangle1)originalRectangle.Clone();
        clonedRectangle.Color = "Yellow"; // Change the color of the cloned rectangle
        Console.WriteLine("Cloned: " + clonedRectangle);
        Console.WriteLine();
        #endregion

        // Behavioral Patterns

        #region Observer Pattern
        Console.WriteLine("Executing Observer Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // Create a stock and two investors (observers).
        Stock appleStock = new Stock("AAPL", 150.00);
        Investor investor1 = new Investor("John Doe");
        Investor investor2 = new Investor("Jane Smith");

        // Register the investors with the stock.
        appleStock.RegisterObserver(investor1);
        appleStock.RegisterObserver(investor2);

        // Change the stock price, which will notify the investors.
        appleStock.Price = 155.00;
        appleStock.Price = 160.00;

        // Remove one investor and change the price again.
        appleStock.RemoveObserver(investor1);
        appleStock.Price = 165.00;
        Console.WriteLine();
        #endregion

        #region Decorator Pattern
        Console.WriteLine("Executing Decorator Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // Start with a simple coffee
        ICoffee myCoffee = new SimpleCoffee();
        Console.WriteLine($"{myCoffee.GetDescription()} - ${myCoffee.GetCost():0.00}");

        // Add milk to the coffee
        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} - ${myCoffee.GetCost():0.00}");

        // Add sugar to the coffee
        myCoffee = new SugarDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} - ${myCoffee.GetCost():0.00}");
        Console.WriteLine();
        #endregion

        #region Adapter Pattern
        Console.WriteLine("Executing Adapter Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // The client expects an ITarget interface
        ITarget target = new Adapter(new Adaptee());
        Console.WriteLine(target.GetRequest());
        Console.WriteLine();
        #endregion

        #region Strategy Pattern
        Console.WriteLine("Executing Strategy Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        PaymentProcessor paymentProcessor = new PaymentProcessor();

        // Set the payment strategy to Credit Card
        paymentProcessor.SetPaymentStrategy(new CreditCardPayment());
        paymentProcessor.ProcessPayment(100.00);

        // Set the payment strategy to PayPal
        paymentProcessor.SetPaymentStrategy(new PayPalPayment());
        paymentProcessor.ProcessPayment(200.00);
        Console.WriteLine();
        #endregion

        #region Command Pattern
        Console.WriteLine("Executing Command Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // Create the receiver
        Light livingRoomLight = new Light();

        // Create the commands
        ICommand lightOn = new LightOnCommand(livingRoomLight);
        ICommand lightOff = new LightOffCommand(livingRoomLight);

        // Create the invoker
        RemoteControl remoteControl = new RemoteControl();

        // Turn the light on
        remoteControl.SetCommand(lightOn);
        remoteControl.PressButton();

        // Turn the light off
        remoteControl.SetCommand(lightOff);
        remoteControl.PressButton();
        Console.WriteLine();
        #endregion

        #region Iterator Pattern
        Console.WriteLine("Executing Iterator Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // Create a book collection
        BookCollection collection = new BookCollection();
        collection.AddBook(new Book("The Catcher in the Rye"));
        collection.AddBook(new Book("To Kill a Mockingbird"));
        collection.AddBook(new Book("1984"));

        // Create an iterator for the book collection
        IBookIterator iterator = collection.CreateIterator();

        // Iterate over the collection
        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine(book.Title);
        }
        Console.WriteLine();
        #endregion

        #region Chain of Responsibility Pattern
        Console.WriteLine("Executing Chain of Responsibility Pattern >>>>>");
        Console.WriteLine("----------------------------------------------------");
        // Create handlers
        SupportHandler basicHandler = new BasicSupportHandler();
        SupportHandler technicalHandler = new TechnicalSupportHandler();
        SupportHandler billingHandler = new BillingSupportHandler();

        // Set up the chain of responsibility
        basicHandler.SetNextHandler(technicalHandler);
        technicalHandler.SetNextHandler(billingHandler);

        // Create and process support requests
        SupportRequest basicRequest = new SupportRequest("Basic", "Password reset");
        SupportRequest technicalRequest = new SupportRequest("Technical", "System not responding");
        SupportRequest billingRequest = new SupportRequest("Billing", "Invoice discrepancy");

        basicHandler.HandleRequest(basicRequest);
        basicHandler.HandleRequest(technicalRequest);
        basicHandler.HandleRequest(billingRequest);
        Console.WriteLine();
        #endregion
    }
}
