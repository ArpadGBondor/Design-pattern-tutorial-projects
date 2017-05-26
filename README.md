The blog, and the videos are not belong to me. 
I just wanted to create the example projects myself, to understand design patterns better.
# Sources:
[Wikipedia](https://en.wikipedia.org/wiki/Software_design_pattern)

[Design pattern tutorial videos by Avish](https://www.youtube.com/playlist?list=PL6n9fhu94yhUbctIoxoVTrklN3LMwTCmd) Links to the blog, are under the videos.

[Design pattern tutorial videos by Michael](https://www.youtube.com/playlist?list=PL8C53D99ABAD3F4C8)

# Design patterns
A pattern is a way to describe a tested, proven solution or approach to a common design problem within a given context in software design.
## 1. Creational patterns
### 1.1. Builder
Separate the construction of a complex object from its representation, allowing the same construction process to create various representations.
### 1.2. Factory
Define an interface for creating a single object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses 
### 1.3. Prototype
Specify the kinds of objects to create using a prototypical instance, and create new objects from the 'skeleton' of an existing object, thus boosting performance and keeping memory footprints to a minimum.
### 1.4. Singleton
Ensure a class has only one instance, and provide a global point of access to it.
 - [kudvenkat - 02](https://youtu.be/YGGg9ecy0K4)
 - [kudvenkat - 03](https://youtu.be/LypTOnfkfvA)
## 2. Structural patterns
### 2.1 Adapter/Wrapper/Translator
Convert the interface of a class into another interface clients expect. An adapter lets classes work together that could not otherwise because of incompatible interfaces. The enterprise integration pattern equivalent is the translator.
### 2.2. Bridge
Decouple an abstraction from its implementation allowing the two to vary independently.	
### 2.3. Composite
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
### 2.4. Decorator
Attach additional responsibilities to an object dynamically keeping the same interface. Decorators provide a flexible alternative to subclassing for extending functionality.
### 2.5. Facade
Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
### 2.6. Flyweight
Use sharing to support large numbers of similar objects efficiently.
### 2.7. Proxy
Provide a surrogate or placeholder for another object to control access to it.
## 3. Behaviour patterns
### 3.1. Chain of responsibility
Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
### 3.2. Command
Encapsulate a request as an object, thereby allowing for the parameterization of clients with different requests, and the queuing or logging of requests. It also allows for the support of undoable operations.
### 3.3. Interpreter
Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
### 3.4. Iterator
Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
 - [Michael - The Iterator Pattern](https://youtu.be/Ns_BPBnPHIU)
### 3.5. Mediator
Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it allows their interaction to vary independently.
### 3.6. Memento
Without violating encapsulation, capture and externalize an object's internal state allowing the object to be restored to this state later.
### 3.7. Null object
Avoid null references by providing a default object.
 - [Michael - The Null Object Pattern](https://youtu.be/RKjpD227tCo)
### 3.8. Observer or Publish/Subscribe
Define a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.
 - [Michael - The Observer Pattern](https://youtu.be/9eoY5fBN12Q)
### 3.9. State
Allow an object to alter its behavior when its internal state changes. The object will appear to change its class
### 3.10. Strategy
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
 - [Michael - The Strategy Pattern](https://youtu.be/94t2ayF1l3o)
### 3.11. Template method
Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
### 3.12. Visitor
Represent an operation to be performed on the elements of an object structure. Visitor lets a new operation be defined without changing the classes of the elements on which it operates.

