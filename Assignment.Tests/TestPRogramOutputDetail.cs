using FizzBuzzConsole;

namespace FizzBuzzTests;

public class TestPRogramOutputDetail
{
    /// <summary>
    /// Validate line output (string) when the value is 5.
    /// Expect Buzz
    /// </summary>
    [Fact]
    public void TestOuputLineMult5()
    {
        // Arrange
        const int input = 5;

        // Setup
        var result = input.FizzBuzz();

        // Assert
        Assert.Equal("005 Buzz", result);
    }

    /// <summary>
    /// Validate line output (string) when the value is 3.
    /// Expect Fizz
    /// </summary>
    [Fact]
    public void TestOuputLineMult3()
    {
        // Arrange
        const int input = 3;

        // Setup
        var result = Extensions.FizzBuzz(input);

        // Assert
        Assert.Equal("003 Fizz", result);
    }

    /// <summary>
    /// Validate line output (string) when the value is 3.
    /// Expect FizzBuzz 
    /// </summary>
    [Fact]
    public void TestOuputLineMult15()
    {
        // Arrange
        const int input = 15;

        // Setup
        var result = input.FizzBuzz();

        // Assert
        Assert.Equal("015 FizzBuzz", result);
    }

    /// <summary>
    /// Validate line output (string) when the value is 3.
    /// Expect nothing 
    /// </summary>
    [Fact]
    public void TestOuputLineMult16()
    {
        // Arrange
        const int input = 16;

        // Setup
        var result = input.FizzBuzz();

        // Assert
        Assert.Equal("016", result);
    }

    [Fact]
    public void TestOuputLineHeader()
    {
        // Setup
        var result = StaticMethods.PrintHeader();

        // Assert
        Assert.Equal("Fizz: Multiple of 3.\r\nBuzz: Multiple of 5.\r\nFizzBuzz: Multiple of both 3 and 5.\r\n\r\n", result);
    }
    
}
