using FizzBuzzConsole;

namespace FizzBuzzTests;

public class TestProgramOutput
{
    /// <summary>
    /// Make sure the number of lines matches expected outputted lines.  100 lines = 101 segments.
    /// </summary>
    [Fact]
    public void TestRangeCount()
    {
        // Arrange
        const int inputStart = 1;
        const int inputEnd = 100;
        const int expected = 100;

        // Setup
        var result = StaticMethods.FizzBuzzRange(inputStart, inputEnd);

        // Assert
        Assert.Equal(expected, result.Split('\n').Length - 1);
    }

    /// <summary>
    /// Test output 1 through 15, literal output with line breaks.
    /// </summary>
    [Fact]
    public void TestRangeLiteralOutput()
    {
        // Arrange
        const int inputStart = 1;
        const int inputEnd = 15;
        const string expected = "001\r\n002\r\n003 Fizz\r\n004\r\n005 Buzz\r\n006 Fizz\r\n007\r\n008\r\n009 Fizz\r\n010 Buzz\r\n011\r\n012 Fizz\r\n013\r\n014\r\n015 FizzBuzz\r\n";

        // Setup
        var result = StaticMethods.FizzBuzzRange(inputStart, inputEnd);

        // Assert
        Assert.Equal(expected, result);

    }
}
