# C# Design Patterns
Sample C# code of various design patterns

## Categories
## Creational Patterns
Purpose: Creational patterns are concerned with the process of object creation. They abstract the instantiation process, making the system independent of how its objects are created, composed, and represented.

Focus: These patterns focus on the best way to create objects, whether it’s by controlling the instantiation process, using constructors, or by using some other means like cloning, or lazily initializing objects.

## Behavioral Patterns
Purpose: Behavioral patterns are concerned with communication between objects. They focus on how objects interact and communicate with each other, ensuring that the system remains flexible and that objects are loosely coupled.

Focus: These patterns are more about the responsibilities of objects and how they cooperate. They help in defining the flow of control in the system.

## Design Patterns
### Singleton
The Singleton pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to it. This pattern restricts the instantiation of a class to a single object, which can be accessed from anywhere in the application. It is useful for managing resources or configurations that should be shared across the system, such as a logging service or a configuration manager.

### Factory
The Factory pattern is a creational design pattern that defines an interface for creating objects but allows subclasses to alter the type of objects that will be created. It encapsulates object creation in a factory method, providing a way to delegate the instantiation process to subclasses. This pattern is useful for managing and abstracting the creation process of complex objects, promoting loose coupling and enhancing flexibility in object creation.

### Abstract Factory
The Abstract Factory pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. It allows you to produce different types of objects that belong to a particular family, ensuring that the objects are compatible with each other. This pattern is useful for managing multiple types of objects and ensuring consistency within a product family, facilitating the creation of objects without tight coupling to their specific implementations.

### Builder
The Builder pattern is a creational design pattern that separates the construction of a complex object from its representation, allowing the same construction process to create different representations. It involves defining a builder interface and concrete builders that provide step-by-step construction of the object. This pattern is useful for constructing complex objects incrementally and flexibly, enabling customization and varying configurations without altering the object’s class.

### Prototype
The Prototype pattern is a creational design pattern that allows for the creation of new objects by copying an existing object, known as the prototype. It involves defining a prototype interface with a method to clone itself. This pattern is useful for creating new instances quickly and efficiently, especially when the cost of creating an object from scratch is high or when you need to create multiple instances with similar configurations.

### Observer
The Observer pattern is a behavioral design pattern that defines a one-to-many dependency between objects, where a change in one object (the subject) automatically notifies and updates all dependent objects (observers). It allows for a decoupled way to manage dependencies, ensuring that all observers are kept up-to-date with the subject's state without the subject needing to know the details of its observers. This pattern is useful for implementing distributed event-handling systems.

### Decorator
The Decorator pattern is a structural design pattern that allows you to dynamically add or modify the behavior of an object at runtime without altering its structure. It involves creating a set of decorator classes that wrap a concrete component, extending its functionalities while keeping the original object's interface intact. This pattern is useful for adding features to objects in a flexible and reusable manner.

### Adapter
The Adapter pattern is a structural design pattern that enables objects with incompatible interfaces to work together. It involves creating an adapter class that wraps an existing class and translates its interface into one that clients expect, allowing for seamless integration without changing the existing code.

### Strategy
The Strategy pattern is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows clients to choose and switch between algorithms or strategies at runtime, promoting flexibility and separation of concerns by decoupling the algorithm implementation from the code that uses it.

### Command
The Command pattern is a behavioral design pattern that encapsulates a request as an object, allowing you to parameterize clients with queues, requests, and operations. It separates the request for an action from the execution of the action, enabling undo/redo operations, queuing of requests, and logging of operations without tightly coupling the requester and receiver.

### Iterator
The Iterator pattern is a behavioral design pattern that provides a way to sequentially access elements of a collection without exposing its underlying representation. It involves defining an iterator interface that allows traversal through the collection, enabling clients to iterate over elements without needing to understand the collection's internal structure.

### Chain of Responsibility
The Chain of Responsibility pattern is a behavioral design pattern that allows a request to be passed along a chain of handlers. Each handler in the chain either processes the request or passes it to the next handler in the chain. This pattern decouples the sender of a request from its receivers, allowing multiple handlers to process the request in a flexible and dynamic manner.
