# Testing and Debugging in C#/.NET

## 1. Unit Testing

Unit testing is essential for ensuring code quality and reliability. In .NET, the most common frameworks are:

- **xUnit**: Modern, extensible, and widely used in the .NET ecosystem.
- **MSTest**: Microsoft's official test framework, integrated with Visual Studio.
- **NUnit**: Popular and feature-rich, with a long history in .NET.

### Example: xUnit Test

```csharp
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSum()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }
}
```

### Best Practices

- Name test methods clearly (e.g., `MethodName_State_ExpectedBehavior`).
- Keep tests independent and repeatable.
- Use test data and setup/teardown methods for complex scenarios.

## 2. Debugging Tools

- **Visual Studio/VS Code Debugger**: Set breakpoints, step through code, inspect variables, and watch expressions.
- **Immediate/Watch Windows**: Evaluate expressions and inspect state during debugging.
- **Call Stack**: Trace the sequence of method calls leading to the current point.
- **Exception Settings**: Break on specific exceptions.

### Debugging Tips

- Use conditional breakpoints to pause only when certain conditions are met.
- Use `Debug.WriteLine()` for temporary logging.
- Inspect local and global variables during execution.

## 3. Test Organization

- Place tests in a separate project (e.g., `MyApp.Tests`).
- Mirror the structure of your main project for clarity.
- Use test categories/traits to group related tests.

## 4. Mocking and Isolation

- Use libraries like **Moq** or **NSubstitute** to mock dependencies.
- Isolate units of code to test only their logic, not external systems.

## 5. Code Coverage

- Use tools like **coverlet** or Visual Studio's built-in coverage to measure how much of your code is tested.
- Aim for high coverage, but focus on meaningful tests over 100% coverage.

## 6. Integration and End-to-End Testing

- Use **WebApplicationFactory** in ASP.NET Core for integration tests.
- Simulate real HTTP requests and database operations.
- Use tools like **Selenium** or **Playwright** for UI/end-to-end tests.

## 7. Continuous Integration (CI)

- Automate test runs using GitHub Actions, Azure DevOps, or other CI tools.
- Fail builds if tests do not pass.

## 8. Debugging in Production

- Use logging frameworks (e.g., Serilog, NLog) for diagnostics.
- Enable Application Insights or similar tools for monitoring.
- Capture and analyze unhandled exceptions.

---

**Resources:**

- [xUnit Documentation](https://xunit.net/docs/getting-started/netcore/cmdline)
- [MSTest Documentation](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)
- [NUnit Documentation](https://nunit.org/)
- [Debugging in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/debugger/)
- [Mocking with Moq](https://github.com/moq/moq4)
- [Code Coverage with coverlet](https://github.com/coverlet-coverage/coverlet)
