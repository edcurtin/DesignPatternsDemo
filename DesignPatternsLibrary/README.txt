Creational Patterns
• Singleton: Ensures a class has only one instance and provides a global point of access to it;
use when a single instance is required to coordinate actions across the system.

• Factory Method: Defines an interface for creating objects but lets subclasses alter the type of objects that will be created; 
use when the exact type of object to be created isn't known until runtime.

• Abstract Factory: Provides an interface for creating families of related or dependent objects without specifying their concrete classes;
use when your code needs to work with various types of objects that share a common interface.

• Builder: Separates the construction of a complex object from its representation; 
use when you need to create different representations of an object using the same construction process.

• Prototype: Creates new objects by copying an existing object, known as the prototype;
use when the cost of creating a new instance of an object is more expensive than copying an existing one.

• Resolver: A pattern to resolve dependencies and configure services at runtime;
use when you need to manage service lifecycles and dependencies dynamically.

Structural Patterns
• Adapter: Allows incompatible interfaces to work together; 
use when you need to integrate new functionality into existing systems without modifying their code.

• Bridge: Decouples an abstraction from its implementation so that the two can vary independently; 
use when you want to avoid a permanent binding between an abstraction and its implementation.

• Composite: Composes objects into tree structures to represent part-whole hierarchies; 
use when you want clients to treat individual objects and compositions of objects uniformly.

• Decorator: Attaches additional responsibilities to an object dynamically;
use when you want to add behavior to individual objects without affecting the behavior of other objects from the same class.

• Facade: Provides a simplified interface to a complex subsystem;
use when you want to reduce the complexity of interactions in a system by providing a single entry point.

• Flyweight: Reduces the cost of creating and managing a large number of similar objects by sharing common data;
use when you need to efficiently manage large quantities of objects.

• Proxy: Provides a surrogate or placeholder for another object to control access to it; 
use when you want to add an additional layer of control over an object’s access or behavior.

Behavioral Patterns
• Chain of Responsibility: Allows a request to be passed along a chain of handlers until one handles it;
use when you want to avoid coupling the sender of a request to its receiver.

• Command: Encapsulates a request as an object, thereby allowing for parameterization and queuing of requests;
use when you need to queue, log, or undo operations.

• Interpreter: Defines a representation for a grammar and an interpreter to evaluate sentences in the language;
use when you need to design a domain-specific language.

• Iterator: Provides a way to access elements of a collection without exposing its underlying representation; 
use when you want to traverse a collection without exposing its internal structure.

• Mediator: Defines an object that encapsulates how a set of objects interact; 
use when you want to reduce coupling between components that communicate with each other.

• Memento: Captures and externalizes an object's internal state without violating encapsulation;
use when you need to restore an object to a previous state.

• Observer: Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified;
use when you want to implement a publish-subscribe mechanism.

• State: Allows an object to alter its behavior when its internal state changes; 
use when you want an object to change its behavior based on its state.

• Strategy: Defines a family of algorithms, encapsulates each one, and makes them interchangeable; 
use when you want to define a set of algorithms and make them interchangeable at runtime.

• Template Method: Defines the skeleton of an algorithm in a method, deferring some steps to subclasses; 
use when you want to define the outline of an algorithm while allowing subclasses to refine specific steps.

• Visitor: Represents an operation to be performed on elements of an object structure; 
use when you want to add new operations to existing object structures without modifying them.

Concurrency Patterns
• ThreadPool: Manages a pool of worker threads to execute tasks; 
use when you want to optimize the execution of a large number of tasks without creating and destroying threads frequently.

• Producer-Consumer: Separates the tasks of producing and consuming data with a shared buffer; 
use when you need to manage resource sharing between threads.

• Observer: In a concurrent context, it allows objects to subscribe to events and get notified when they occur;
use when you need to maintain communication between objects in a multi-threaded environment.