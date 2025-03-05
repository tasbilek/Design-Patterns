
# Design Patterns

This repository contains various design patterns implemented in C#. The purpose of this repository is to demonstrate and explain the most commonly used design patterns in software development. 

## Table of Contents

- [Creational Patterns](#creational-patterns)
  - [Singleton Pattern](#singleton-pattern)
  - [Factory Method Pattern](#factory-method-pattern)
  - [Builder Pattern](#builder-pattern)
  
- [Structural Patterns](#structural-patterns)
  - [Adapter Pattern](#adapter-pattern)
  - [Decorator Pattern](#decorator-pattern)
  - [Proxy Pattern](#proxy-pattern)

- [Behavioral Patterns](#behavioral-patterns)
  - [Observer Pattern](#observer-pattern)
  - [Strategy Pattern](#strategy-pattern)
  - [State Pattern](#state-pattern)
  - [Chain of Responsibility Pattern](#chain-of-responsibility-pattern)

---

## Creational Patterns

Creational patterns deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. These patterns abstract the process of object creation.

### Singleton Pattern
Ensures that a class has only one instance and provides a global point of access to it.

**Use Case:**  
When you need a single shared instance for resource management (e.g., configuration manager, logging system).

### Factory Method Pattern
Allows a class to delegate the responsibility of object creation to its subclasses.

**Use Case:**  
When you need to create objects, but you don’t know in advance what type of object needs to be created.

### Builder Pattern
Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

**Use Case:**  
When you need to create an object with many possible configurations or variations (e.g., constructing a house with different features).

---

## Structural Patterns

Structural patterns deal with object composition, allowing you to create relationships between objects to form larger structures.

### Adapter Pattern
Converts one interface to another, allowing classes with incompatible interfaces to work together.

**Use Case:**  
When you need to integrate a new system with an existing one, or when using incompatible APIs.

### Decorator Pattern
Allows you to dynamically add responsibilities to an object.

**Use Case:**  
When you need to add additional features to an object without modifying its code.

### Proxy Pattern
Provides an object representing another object, controlling access to it.

**Use Case:**  
When you need to control access to an object, such as lazy initialization, access control, or remote proxy.

---

## Behavioral Patterns

Behavioral patterns deal with communication between objects and the responsibilities of those objects.

### Observer Pattern
Allows one object (subject) to notify other objects (observers) when its state changes.

**Use Case:**  
Used for implementing notification systems where one subject can notify multiple observers (e.g., news feed, social media).

### Strategy Pattern
Defines a family of algorithms and allows one to be selected at runtime.

**Use Case:**  
When you need to switch between different algorithms or behaviors dynamically.

### State Pattern
Allows an object to alter its behavior when its internal state changes.

**Use Case:**  
When you have an object that can be in multiple states, and its behavior changes based on the current state.

### Chain of Responsibility Pattern
Allows passing a request along a chain of handlers, where each handler can either process the request or pass it along to the next handler.

**Use Case:**  
When you have a chain of processes, and each process may either handle the request or pass it along.

---

## Installation and Usage

Clone the repository to your local machine:

```bash
git clone https://github.com/tasbilek/Design-Patterns.git
```

Restore dependencies:

```bash
dotnet restore
```

Run the project:

```bash
dotnet run
```

---

## Contributing

If you would like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new feature branch (`git checkout -b feature/YourFeature`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add new feature'`).
5. Push your changes to the main branch.
6. Open a pull request.

---

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).
