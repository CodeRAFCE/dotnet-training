# Variables and Data Types in C# (.NET)

## What is a Variable?

A variable is a named storage location in memory that holds a value. You can assign, read, and change its value during program execution.

## Common Data Types

| Type      | Example              | Description                                                                                  |
| --------- | -------------------- | -------------------------------------------------------------------------------------------- |
| `int`     | `int x = 10;`        | 32-bit signed integer. Used for whole numbers (e.g., 1, -5, 100).                            |
| `double`  | `double d = 5.5;`    | 64-bit double-precision floating-point number. Used for decimals with high precision.        |
| `string`  | `string s = "hi";`   | Sequence of Unicode characters. Used for text (e.g., names, sentences).                      |
| `bool`    | `bool b = true;`     | Boolean value. Represents `true` or `false`. Often used for conditions and logic.            |
| `char`    | `char c = 'A';`      | Single 16-bit Unicode character. Used for individual letters or symbols.                     |
| `float`   | `float f = 3.14f;`   | 32-bit single-precision floating-point number. Less precise than `double`, uses less memory. |
| `decimal` | `decimal m = 9.99m;` | 128-bit high-precision decimal number. Ideal for financial and monetary calculations.        |

## Declaring Variables

To declare a variable, specify its type followed by its name and an optional initial value:

```csharp
int age = 30;
string name = "John";
double salary = 45000.50;
bool isEmployed = true;
char grade = 'A';
```

## Type Inference with `var`

C# can infer the type from the assigned value:

```csharp
var city = "London";      // string
var temperature = 23.5;   // double
var isOpen = false;       // bool
```

## Constants

Use `const` to declare a value that cannot change:

```csharp
const double Pi = 3.14159;
```

## Naming Conventions

- Use **camelCase** for local variables (`int myNumber`).
- Use **PascalCase** for constants (`const int MaxValue`).

## Practice

Try declaring variables of each type, assign values, and print them to the console using both latest and old syntax.

---

**Next:** Learn about Input and Output in C#.
