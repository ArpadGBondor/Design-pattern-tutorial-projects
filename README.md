The videos are not belong to me. 
I just wanted to create the example projects myself, to understand design patterns better.
# Sources:
[Wikipedia](https://en.wikipedia.org/wiki/Software_design_pattern)

[Design pattern tutorial videos by Avish](https://www.youtube.com/playlist?list=PL6n9fhu94yhUbctIoxoVTrklN3LMwTCmd) Links to the blog, are under the videos.

[Design pattern tutorial videos by Michael](https://www.youtube.com/playlist?list=PL8C53D99ABAD3F4C8)

[Design pattern tutorial videos by Scott Lilly](https://www.youtube.com/playlist?list=PL3SyMdYUavDjBplxSmo2uC5sA9_r1nRyT)

# Content
 - [1. Creational patterns](#1-creational-patterns)
 - [2. Structural patterns](#2-structural-patterns)
 - [3. Behaviour patterns](#3-behaviour-patterns)
 - [4. Concurrency patterns](#4-concurrency-patterns)
 - [5. Architectural patterns](#5-architectural-patterns)
# Design patterns
 - A pattern is a way to describe a tested, proven solution or approach to a common design problem within a given context in software design.
## 1. Creational patterns
 - These patterns deal with object creation mechanisms, trying to create in a manner suitable to the situation.
 - The basic form of object creation could result in design problems or added complexity to the design.
### 1.1. Builder
 - Separate the construction of a complex object from its representation, allowing the same construction process to create various representations.
### 1.2. Factory
 - Define an interface for creating a single object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses 
 - Video: [Scott Lilly - C# Design Patterns: The Factory Pattern](https://youtu.be/Y5X4odRW00M)
### 1.3. Prototype
 - Specify the kinds of objects to create using a prototypical instance, and create new objects from the 'skeleton' of an existing object, thus boosting performance and keeping memory footprints to a minimum.
 - Video: [Michael - The Prototype Pattern](https://youtu.be/jFquZRf5jIo)
### 1.4. Singleton
 - Ensure a class has only one instance, and provide a global point of access to it.
 - Video: [kudvenkat - 02](https://youtu.be/YGGg9ecy0K4)
 - Video: [kudvenkat - 03](https://youtu.be/LypTOnfkfvA)
 - Video: [Michael - The Singleton Pattern](https://youtu.be/xgkbirZrwAs)
 - Video: [Scott Lilly - C# Design Patterns: The Singleton Pattern](https://youtu.be/nAKN48JiGyQ) <- The best so far.
## 2. Structural patterns
 - These patterns ease the design by identifying a simple way to realise relationships between entities.
### 2.1 Adapter/Translator
 - Convert the interface of a class into another interface clients expect. An adapter lets classes work together that could not otherwise because of incompatible interfaces. The enterprise integration pattern equivalent is the translator.
 - Video: [Michael - The Adapter Pattern](https://youtu.be/TriX8OiEhOU)
### 2.2. Bridge
 - Decouple an abstraction from its implementation allowing the two to vary independently.	
### 2.3. Composite
 - Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
 - Video: [Michael - The Composite Pattern](https://youtu.be/mbNe9ioINHU)
### 2.4. Decorator
 - Attach additional responsibilities to an object dynamically keeping the same interface. Decorators provide a flexible alternative to subclassing for extending functionality.
 - Video: [Michael - The Decorator Pattern - Warning Audio spikes! :(](https://youtu.be/nk9Z1vwO3RI)
### 2.5. Facade/Wrapper
 - Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
 - Video: [Michael - The Facade Pattern](https://youtu.be/WLjvNpP6yeQ)
 - Video: [Scott Lilly - C# Design Patterns: The Wrapper/Facade Pattern](https://youtu.be/a2Qh10YjP6Y)
### 2.6. Flyweight
 - Use sharing to support large numbers of similar objects efficiently.
### 2.7. Proxy
 - Provide a surrogate or placeholder for another object to control access to it.
## 3. Behaviour patterns
 - These patterns identify common communication patterns between objects and realize these patterns. By doing so, these patterns increase flexibility in carrying out this communication.
### 3.1. Chain of responsibility
 - Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
### 3.2. Command
 - Encapsulate a request as an object, thereby allowing for the parameterization of clients with different requests, and the queuing or logging of requests. It also allows for the support of undoable operations.
 - Video: [Michael - The Command Pattern](https://youtu.be/_3DHEIHxuMM)
 - Video: [Scott Lilly - C# Design Patterns: The Command Pattern](https://youtu.be/t_frFWqrnJE)
### 3.3. Interpreter
 - Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
### 3.4. Iterator
 - Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
 - Video: [Michael - The Iterator Pattern](https://youtu.be/Ns_BPBnPHIU)
### 3.5. Mediator
 - Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it allows their interaction to vary independently.
### 3.6. Memento
 - Without violating encapsulation, capture and externalize an object's internal state allowing the object to be restored to this state later.
 - Video: [Michael - The Memento Pattern](https://youtu.be/OfD9QBZ0Qfc)
 - Video: [Scott Lilly - C# Design Patterns: The Memento Pattern](https://youtu.be/ofp0o0J1dh0)
### 3.7. Null object
 - Avoid null references by providing a default object.
 - Video: [Michael - The Null Object Pattern](https://youtu.be/RKjpD227tCo)
### 3.8. Observer or Publish/Subscribe
 - Define a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.
 - Video: [Michael - The Observer Pattern](https://youtu.be/9eoY5fBN12Q)
### 3.9. State
 - Allow an object to alter its behavior when its internal state changes. The object will appear to change its class
### 3.10. Strategy
 - Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
 - Video: [Michael - The Strategy Pattern](https://youtu.be/94t2ayF1l3o)
 - Video: [Scott Lilly - C# Design Patterns: The Strategy Pattern](https://youtu.be/b4ssMlADWTM)
### 3.11. Template method
 - Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
 - Video: [Michael - The Template Method Pattern](https://youtu.be/zeRSYj-bVqo)
### 3.12. Visitor
 - Represent an operation to be performed on the elements of an object structure. Visitor lets a new operation be defined without changing the classes of the elements on which it operates.
## 4. Concurrency patterns
 - These type of design patterns deal with the multi-threaded programming paradigm.
### 4.1. Active object
 - [Wiki](https://en.wikipedia.org/wiki/Active_object)
### 4.2. Balking
 - [Wiki](https://en.wikipedia.org/wiki/Balking_pattern)
### 4.3. Barrier
 - [Wiki](https://en.wikipedia.org/wiki/Barrier_(computer_science))
### 4.4. Binding properties
 - [Wiki](https://en.wikipedia.org/wiki/Binding_properties_pattern)
### 4.5. Double-checked locking
 - [Wiki](https://en.wikipedia.org/wiki/Double-checked_locking)
### 4.6. Event-based asynchronous method invocation (AMI)
 - [Wiki](https://en.wikipedia.org/wiki/Asynchronous_method_invocation)
### 4.7. Guarded suspension
 - [Wiki](https://en.wikipedia.org/wiki/Guarded_suspension)
### 4.8. Join
 - [Wiki](https://en.wikipedia.org/wiki/Join-pattern)
### 4.9. Lock
 - [Wiki](https://en.wikipedia.org/wiki/Lock_(computer_science))
### 4.10. Monitor
 - [Wiki](https://en.wikipedia.org/wiki/Monitor_(synchronization))
### 4.11. Proactor
 - [Wiki](https://en.wikipedia.org/wiki/Proactor_pattern)
### 4.12. Reactor
 - [Wiki](https://en.wikipedia.org/wiki/Reactor_pattern)
### 4.13. Read/Write lock
 - [Wiki](https://en.wikipedia.org/wiki/Readers%E2%80%93writer_lock)
### 4.14. Scheulder
 - [Wiki](https://en.wikipedia.org/wiki/Scheduling_(computing))
### 4.15. Thread pool
 - [Wiki](https://en.wikipedia.org/wiki/Thread_pool)
### 4.16. Thread-local pool
 - [Wiki](https://en.wikipedia.org/wiki/Thread-local_storage)
## 5. Architectural patterns
 - An architectural pattern is a concept that solves and delineates some essential cohesive elements of a software architecture. Countless different architectures may implement the same pattern and share the related characteristics.
### 5.1. Front controller
 - [Wiki](https://en.wikipedia.org/wiki/Front_controller)
### 5.2. Interceptor
 - [Wiki](https://en.wikipedia.org/wiki/Interceptor_pattern)
### 5.3. MVC
 - [Wiki](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller)
### 5.4. n-tier
 - [Wiki](https://en.wikipedia.org/wiki/Multitier_architecture)
### 5.5. Specification
 - [Wiki](https://en.wikipedia.org/wiki/Specification_pattern)
### 5.6. Publish-subscribe
 - [Wiki](https://en.wikipedia.org/wiki/Publish%E2%80%93subscribe_pattern)
### 5.7. Naked objects
 - [Wiki](https://en.wikipedia.org/wiki/Naked_objects)
### 5.8. Service locator
 - [Wiki](https://en.wikipedia.org/wiki/Service_locator_pattern)
### 5.9. Active record
 - [Wiki](https://en.wikipedia.org/wiki/Active_record_pattern)
 - Video: [Scott Lilly - C# Design Patterns: The Data Mapper pattern and the Active Record pattern](https://youtu.be/xlSZDw5j4GM)
### 5.10. Identity map
 - [Wiki](https://en.wikipedia.org/wiki/Identity_map_pattern)
### 5.11. Data access object
 - [Wiki](https://en.wikipedia.org/wiki/Data_access_object)
### 5.12. Date mapper
 - [Wiki](https://en.wikipedia.org/wiki/Data_mapper_pattern)
 - Video: [Scott Lilly - C# Design Patterns: The Data Mapper pattern and the Active Record pattern](https://youtu.be/xlSZDw5j4GM)
### 5.13. Data transfer object
 - [Wiki](https://en.wikipedia.org/wiki/Data_transfer_object)
### 5.14. Inversion of control
 - [Wiki](https://en.wikipedia.org/wiki/Inversion_of_control)
