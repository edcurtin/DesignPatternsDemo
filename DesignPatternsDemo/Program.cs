using DesignPatternsLibrary.Creational._6._Resolver;
using DesignPatternsLibrary.Creational._5._Prototype;
using DesignPatternsLibrary.Creational.Interfaces;
using DesignPatternsLibrary.Services;
using Microsoft.Extensions.DependencyInjection;
using DesignPatternsLibrary.Creational._2._Factory_Method;
using DesignPatternsLibrary.Creational._4._Builder;
using DesignPatternsLibrary.Creational_5._Prototype;
using DesignPatternsLibrary.Structural_1.Adapter;
using DesignPatternsLibrary.Structural._1.Adapter;
using DesignPatternsLibrary.Structural._2._Bridge;
using DesignPatternsLibrary.Structural._4._Decorator;
using DesignPatternsLibrary.Structural._5._Facade;
using DesignPatternsLibrary.Structural._6._Flyweight;
using DesignPatternsLibrary.Structural._7._Proxy;
using DesignPatternsLibrary.Behavioral._1._Command;
using DesignPatternsLibrary.EventSourcing;
using DesignPatternsLibrary.Behavioral._3._Interator;
using MediatR;
using DesignPatternsLibrary.Behavioral._4._Mediator;
using DesignPatternsLibrary.Behavioral._5._Memento;
using DesignPatternsLibrary.Behavioral._6._Observer;
using DesignPatternsLibrary.Behavioral._7._State;
using DesignPatternsLibrary.Behavioral._8._Strategy;
using DesignPatternsLibrary.Behavioral._9._Template_Method;
using DesignPatternsLibrary.Behavioral._10._Visitor;
using DesignPatternsLibrary.Concurrency._3._Observer;
using DesignPatternsLibrary.Concurrency._2._ProducerConsumer;
using DesignPatternsLibrary.Concurrency._1._ThreadPool;
using DesignPatternsLibrary.Behavioral._11._Chain_Of_Responsibility;

class Program
{
    static async Task Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ILoggerService, LoggerService>()
            .AddTransient<LocalLoggerFactory>()
            .AddTransient<CloudLoggerFactory>()
            .AddTransient<DoFunkyStuffResolver>()
            .AddMediatR(typeof(Program).Assembly)
            .AddMediatR(typeof(GreetingHandler).Assembly)
            .BuildServiceProvider();


        // Get the logger service from the DI container
        var loggerService = serviceProvider.GetService<ILoggerService>();

        // Log messages and display them
        loggerService.Log("This is the first log entry.");
        loggerService.Log("This is the second log entry.");

        var logs = loggerService.GetAllLogs();

        var loggerFactory = serviceProvider.GetService<LocalLoggerFactory>();
        var localFileWriter = loggerFactory.CreateFileWriter();

        var resolver = serviceProvider.GetRequiredService<DoFunkyStuffResolver>();
        var doFunkyStuffA = resolver.GetDoFunkyStuff("a");
        var doFunkyStuffB = resolver.GetDoFunkyStuff("b");

        // Create a product using the builder pattern
        Product product = new ProductBuilder()
            .SetName("Widget")
            .SetSize("Medium")
            .SetColor("Red")
            .Build();

        // Display the created product
        Console.WriteLine(product);

        // Prototype Pattern
        var prototypeA = new ConcretePrototypeA("Original A");
        var prototypeB = new ConcretePrototypeB(42);

        // Clone the prototypes
        var clonedPrototypeA = prototypeA.Clone();
        var clonedPrototypeB = prototypeB.Clone();

        // Modify cloned objects
        clonedPrototypeA.PropertyA = "Cloned A";
        clonedPrototypeB.PropertyB = 99;

        // Show that original objects are unchanged
        Console.WriteLine($"After modification:");
        Console.WriteLine($"Original A: {prototypeA.PropertyA}, Cloned A: {clonedPrototypeA.PropertyA}");
        Console.WriteLine($"Original B: {prototypeB.PropertyB}, Cloned B: {clonedPrototypeB.PropertyB}");

        // Structural

        //Adapter

        IPaymentProcessor stripeProcessor = new CreditCardAdapter(new DesignPatternsLibrary.Structural_1.Adapter.CreditCardPayment());
        stripeProcessor.ProcessPayment(100.00m);

        IPaymentProcessor paypalProcessor = new PayPalAdapter(new PaypalPayment());
        paypalProcessor.ProcessPayment(150.00m);

        // Bridge Design Pattern
        IDevice television = new Television();
        RemoteControl tvRemote = new AdvancedRemoteControl(television);

        tvRemote.PressOnButton();
        tvRemote.PressOffButton();

        Console.WriteLine();

        // Create a Radio and a Remote Control for it
        IDevice radio = new Radio();
        RemoteControl radioRemote = new AdvancedRemoteControl(radio);

        radioRemote.PressOnButton();
        radioRemote.PressOffButton();


        // Composite 
        // Creating leaf objects (files)
        var file1 = new DesignPatternsLibrary.Structural._3._Composite.File("File1.txt");
        var file2 = new DesignPatternsLibrary.Structural._3._Composite.File("File2.txt");
        var file3 = new DesignPatternsLibrary.Structural._3._Composite.File("File3.txt");

        // Creating composite objects (directories)
        var rootDirectory = new DesignPatternsLibrary.Structural._3._Composite.Directory("Root Directory");
        var subDirectory1 = new DesignPatternsLibrary.Structural._3._Composite.Directory("Sub Directory 1");
        var subDirectory2 = new DesignPatternsLibrary.Structural._3._Composite.Directory("Sub Directory 2");

        // Building the composite structure
        rootDirectory.Add(file1);
        rootDirectory.Add(subDirectory1);

        subDirectory1.Add(file2);
        subDirectory1.Add(subDirectory2);

        subDirectory2.Add(file3);

        // Displaying the structure
        Console.WriteLine("File System Structure:");
        rootDirectory.Display(1);

        // Decorator Pattern
        // Create a simple coffee
        ICoffee myCoffee = new SimpleCoffee();
        Console.WriteLine($"{myCoffee.GetDescription()} -> Cost: {myCoffee.GetCost()}");

        // Add milk to the coffee
        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} -> Cost: {myCoffee.GetCost()}");

        // Add sugar to the coffee
        myCoffee = new SugarDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} -> Cost: {myCoffee.GetCost()}");

        // Final decorated coffee
        Console.WriteLine($"\nFinal Coffee: {myCoffee.GetDescription()} -> Total Cost: {myCoffee.GetCost()}");

        // Create the subsystems
        Projector projector = new Projector();
        SoundSystem soundSystem = new SoundSystem();
        DVDPlayer dvdPlayer = new DVDPlayer();

        // Create the facade
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(projector, soundSystem, dvdPlayer);

        // Use the facade to watch a movie
        homeTheater.WatchMovie("Inception");

        Console.WriteLine("\nPress any key to stop the movie...");
        Console.ReadKey();

        // Use the facade to end the movie
        homeTheater.EndMovie();


        // Flyweight Design Pattern
        var forest = new Forest();

        // Planting trees
        forest.PlantTree(1, 2, "Oak", "Green", "Rough");
        forest.PlantTree(3, 5, "Pine", "Dark Green", "Smooth");
        forest.PlantTree(7, 9, "Oak", "Green", "Rough");
        forest.PlantTree(12, 15, "Pine", "Dark Green", "Smooth");

        // Drawing all the trees
        forest.Draw();

        // Proxy 
        DesignPatternsLibrary.Structural._7._Proxy.ISubject subject = new Proxy();

        // Client code can use the Proxy instead of the RealSubject
        subject.Request();


        // Command Design Pattern
        var items = new List<string>();
        var commandInvoker = new CommandInvoker();

        // Adding items
        var addCommand1 = new AddItemCommand(items, "Item1");
        var addCommand2 = new AddItemCommand(items, "Item2");
        commandInvoker.StoreCommand(addCommand1);
        commandInvoker.StoreCommand(addCommand2);

        // Execute add commands
        commandInvoker.ExecuteCommands();

        // Removing an item
        var removeCommand = new RemoveItemCommand(items, "Item1");
        commandInvoker.StoreCommand(removeCommand);

        // Execute remove commands
        commandInvoker.ExecuteCommands();

        // Display remaining items
        Console.WriteLine("Current items in the list:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }


        // Initialize account and event store
        BankAccount account = new BankAccount();
        EventStore eventStore = new EventStore();

        Console.WriteLine("Creating a new bank account...");
        Console.WriteLine(account);

        // Apply some events
        var deposit = new DepositEvent(100);
        eventStore.SaveEvent(deposit);
        deposit.Apply(account);

        var withdrawal = new WithdrawalEvent(50);
        eventStore.SaveEvent(withdrawal);
        withdrawal.Apply(account);

        Console.WriteLine("\nAfter transactions:");
        Console.WriteLine(account);

        Console.WriteLine("\nEvent log:");
        foreach (var e in eventStore.GetEvents())
        {
            Console.WriteLine(e);
        }

        // Rebuilding account from events
        Console.WriteLine("\nRebuilding account from event history...");
        var newAccount = new BankAccount();
        eventStore.ReplayEvents(newAccount);
        Console.WriteLine(newAccount);


        // Iterator Pattern
        ConcreteCollection collection = new ConcreteCollection();
        collection.AddItem("Item 1");
        collection.AddItem("Item 2");
        collection.AddItem("Item 3");
        collection.AddItem("Item 4");

        // Create an iterator for the collection
        IIterator iterator = collection.CreateIterator();

        // Iterate through the collection using the iterator
        Console.WriteLine("Iterating over collection:");
        while (iterator.HasNext())
        {
            var item = iterator.Next();
            Console.WriteLine(item);
        }

        // Get IMediator from the service provider
        var mediator = serviceProvider.GetRequiredService<IMediator>();

        // Send a request
        string name = "John";
        var greeting = mediator.Send(new GreetingRequest(name));

        // Output the result
        Console.WriteLine(greeting.Result);

        // Memento Design Pattern
        // Create an originator (text editor) with some initial content
        TextEditor editor = new TextEditor("Initial text.");

        // Create a caretaker to manage the history of mementos
        TextEditorHistory history = new TextEditorHistory();

        // Show initial content
        editor.ShowContent();

        // Save state
        history.SaveState(editor.Save());

        // Modify content
        editor.Content = "First change.";
        editor.ShowContent();

        // Save state after change
        history.SaveState(editor.Save());

        // Modify content again
        editor.Content = "Second change.";
        editor.ShowContent();

        // Undo to previous state
        Console.WriteLine("Undoing last change...");
        editor.Restore(history.Undo());
        editor.ShowContent();

        // Undo to initial state
        Console.WriteLine("Undoing to initial state...");
        editor.Restore(history.Undo());
        editor.ShowContent();

        // Observer Pattern

        WeatherStation weatherStation = new WeatherStation();

        // Create observers
        PhoneDisplay phoneDisplay = new PhoneDisplay(weatherStation);
        WindowDisplay windowDisplay = new WindowDisplay(weatherStation);

        // Simulate changing temperature
        weatherStation.SetTemperature(25.0f);
        weatherStation.SetTemperature(30.5f);

        // Unregister window display and change temperature again
        weatherStation.RemoveObserver(windowDisplay);
        weatherStation.SetTemperature(22.3f);

        Ticket ticket = new Ticket();

        // Ticket starts in "New" state
        Console.WriteLine("Initial state: New");
        ticket.Next();  // Transitions to "In Progress"

        ticket.Next();  // Transitions to "Closed"

        ticket.Next();  // No further transition, already closed

        Console.ReadKey();

        // Strategy Pattern
        // Create the context
        PaymentContext context = new PaymentContext();

        // Simulating user input for payment strategy choice
        Console.WriteLine("Select a payment method: 1. Credit Card  2. PayPal  3. Bitcoin");
        string? input = Console.ReadLine();

        // Set the strategy based on user input
        switch (input)
        {
            case "1":
                context.SetPaymentStrategy(new DesignPatternsLibrary.Behavioral._8._Strategy.CreditCardPayment());
                break;
            case "2":
                context.SetPaymentStrategy(new PayPalPayment());
                break;
            case "3":
                context.SetPaymentStrategy(new BitcoinPayment());
                break;
            default:
                Console.WriteLine("Invalid option. No payment strategy selected.");
                return;
        }

        // Pay the amount using the selected strategy
        context.PayAmount(125.00m);



        Console.WriteLine("Making coffee:");
        Beverage coffee = new Coffee();
        coffee.PrepareRecipe();

        Console.WriteLine("Making tea:");
        Beverage tea = new Tea();
        tea.PrepareRecipe();

        // Visitor Pattern
        // Create some shapes
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 7);

        // Create visitors
        AreaVisitor areaVisitor = new AreaVisitor();
        PerimeterVisitor perimeterVisitor = new PerimeterVisitor();

        // Visit shapes with area visitor
        Console.WriteLine("Calculating Areas:");
        circle.Accept(areaVisitor);
        rectangle.Accept(areaVisitor);

        // Visit shapes with perimeter visitor
        Console.WriteLine("Calculating Perimeters:");
        circle.Accept(perimeterVisitor);
        rectangle.Accept(perimeterVisitor);


        var sensor = new Sensor();

        // Create multiple observers
        var observer1 = new DataObserver("Observer 1");
        var observer2 = new DataObserver("Observer 2");

        // Subscribe observers to the sensor
        sensor.Subscribe(observer1);
        sensor.Subscribe(observer2);

        // Create a cancellation token for stopping the sensor data generation
        var cancellationTokenSource = new CancellationTokenSource();

        // Run sensor data generation asynchronously
        var sensorTask = sensor.GenerateDataAsync(cancellationTokenSource.Token);

        // Let the sensor run for 10 seconds
        await Task.Delay(10000);

        // Stop the sensor and cancel the task
        sensor.Stop();
        cancellationTokenSource.Cancel();

        // Await the completion of the task
        await sensorTask;

        Console.WriteLine("Sensor stopped");


        var producerConsumerManager = new ProducerConsumerManager(boundedCapacity: 5);
        Console.WriteLine("Starting producer-consumer pattern...");
        await producerConsumerManager.StartProcessing(producerCount: 2, consumerCount: 2);

        Console.WriteLine("Processing complete.");

        // ThreadPool Example
        // Create an instance of ThreadPoolExample
        var threadPoolExample = new ThreadPoolExample();

        // Define the number of tasks to run
        int numberOfTasks = 10;

        // Run the tasks
        threadPoolExample.RunTasks(numberOfTasks);

        // Wait for user input to exit
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();


        // Create handlers
        var handlerA = new ConcreteHandlerA();
        var handlerB = new ConcreteHandlerB();

        // Set up the chain of responsibility
        handlerA.SetNext(handlerB);

        // Create some requests
        var requests = new[] { "A", "B", "C" };

        // Process requests
        foreach (var request in requests)
        {
            Console.WriteLine($"Processing request: {request}");
            handlerA.HandleRequest(request);
            Console.WriteLine();
        }
    }
}