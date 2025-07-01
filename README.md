# .NET/C# Learning Project

This repository is dedicated to learning and practicing .NET and C# development. It contains exercises, sample code, and notes to help understand the fundamentals and advanced concepts of the .NET ecosystem.

## About C# and .NET

- **C#** is a modern, object-oriented programming language developed by Microsoft.
- **.NET** is a free, open-source developer platform for building many types of applications (web, desktop, mobile, cloud, etc.) using C# and other languages.

## About .NET and .NET Framework

- **.NET (Core/5/6/7/8+)** is a modern, cross-platform, open-source developer platform for building many types of applications (web, desktop, mobile, cloud, etc.) using C#, F#, or VB.NET. It is the current and recommended platform for new projects.
- **.NET Framework (up to v4.8.1)** is the original, Windows-only version of .NET. It is still supported for maintaining legacy applications, but new development should use .NET (Core/5/6/7/8+).
- **Key difference:** .NET is cross-platform and open-source, while .NET Framework is Windows-only and closed-source.

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

### LatestSyntax (Top-level statements)

This is the modern C# approach (C# 9.0+), where you don't need to explicitly declare a `Main` method. Code can be written directly at the top level of the file.

```csharp
// LatestSyntax Example
int age = 25;
string name = "Alice";
Console.WriteLine($"Hello, {name}! You are {age} years old.");
```

### ClassicSyntax (Explicit Main method)

This is the traditional C# approach, where you must define a `Main` method as the program entry point. This style is still widely used and is required for .NET Framework projects and some advanced scenarios.

```csharp
// ClassicSyntax Example
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

## How to Run C# Code

To run a C# project using the .NET CLI:

1. Open a terminal or command prompt.
2. Navigate to your project folder (where the `.csproj` file is located):
   ```
   cd path/to/your/project
   ```
3. Run the project:
   ```
   dotnet run
   ```

This will build and execute your C# application. You should see the output in your terminal.

## What are NuGet Packages?

- **NuGet** is the package manager for .NET. It allows you to add, update, and manage third-party libraries and tools in your projects.
- Packages are published on [nuget.org](https://www.nuget.org/), the official NuGet package repository.

### How to Add NuGet Packages

**Using the .NET CLI:**

1. Open a terminal and navigate to your project folder.
2. Run:
   ```
   dotnet add package <PackageName>
   ```
   Example:
   ```
   dotnet add package Newtonsoft.Json
   ```

**Using Visual Studio:**

1. Right-click your project in Solution Explorer.
2. Select "Manage NuGet Packages..."
3. Search for the package and click "Install".

NuGet will automatically download the package and update your project files.

---

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
