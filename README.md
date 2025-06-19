# .NET/C# Learning Project

This repository is dedicated to learning and practicing .NET and C# development. It contains exercises, sample code, and notes to help understand the fundamentals and advanced concepts of the .NET ecosystem.

## About C# and .NET

- **C#** is a modern, object-oriented programming language developed by Microsoft.
- **.NET** is a free, open-source developer platform for building many types of applications (web, desktop, mobile, cloud, etc.) using C# and other languages.

## Object-Oriented Programming (OOP) Concepts in C#

C# is built around OOP principles, which help organize and structure code. The four main OOP concepts are:

- **Encapsulation:** Bundling data and methods that operate on that data within a class.
- **Abstraction:** Hiding complex implementation details and showing only the necessary features.
- **Inheritance:** Creating new classes based on existing ones, enabling code reuse.
- **Polymorphism:** Allowing objects to be treated as instances of their parent class, enabling flexibility and dynamic behavior.

Example:

```csharp
// Encapsulation & Inheritance Example
class Animal
{
    public string Name { get; set; }
    public void Speak() => Console.WriteLine($"{Name} makes a sound.");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine($"{Name} barks.");
}

// Polymorphism Example
Animal myDog = new Dog { Name = "Rex" };
myDog.Speak(); // Output: Rex makes a sound.
```

## Common .NET Template Types

| Template Name | Command Example         | Use-Case                              |
| ------------- | ----------------------- | ------------------------------------- |
| console       | dotnet new console      | Command-line apps, learning basics    |
| classlib      | dotnet new classlib     | Reusable libraries, shared code       |
| web           | dotnet new web          | ASP.NET Core web apps, APIs           |
| mvc           | dotnet new mvc          | ASP.NET Core MVC web apps             |
| webapi        | dotnet new webapi       | RESTful APIs, backend services        |
| blazorserver  | dotnet new blazorserver | Blazor Server web apps                |
| blazorwasm    | dotnet new blazorwasm   | Blazor WebAssembly (client-side) apps |
| worker        | dotnet new worker       | Background services                   |
| xunit         | dotnet new xunit        | Unit testing with xUnit               |

## Helpful .NET CLI Commands for Beginners

- `dotnet new --list` — List all available project templates
- `dotnet new <TEMPLATE> -o <FOLDER>` — Create a new project from a template
- `dotnet run` — Build and run the current project
- `dotnet build` — Build the current project
- `dotnet clean` — Clean the build output
- `dotnet help` — Show help for the .NET CLI
- `dotnet --info` — Show .NET SDK info

## Basic C# Syntax Overview

```csharp
// Latest Syntax (Top-level statements)
int age = 25;
string name = "Alice";
Console.WriteLine($"Hello, {name}! You are {age} years old.");

// Old Syntax (Explicit Main method)
using System;
class Program
{
    static void Main()
    {
        int age = 25;
        string name = "Alice";
        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }
}
```

## Purpose

- Explore C# language features
- Practice .NET application development
- Experiment with libraries, tools, and frameworks
- Document learning progress and key takeaways

## Getting Started

1. Clone this repository.
2. Open it in your favorite IDE (e.g., Visual Studio, VS Code).
3. Follow along with the exercises or add your own.

## License

This project is for educational purposes.
