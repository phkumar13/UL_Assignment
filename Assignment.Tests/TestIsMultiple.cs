using FizzBuzzConsole;

namespace FizzBuzzTests;

public class TestIsMultiple
{
    [Fact]
    public void TestMultiple3_Positive()
    {
        // Arrange
        const int input = 3;
        const bool expected = true;

        // Setup
        var obj = new Multiple(input);

        var result = obj.IsMultofThree();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMultiple3_Negative()
    {
        // Arrange
        const int input = 4;
        const bool expected = false;

        // Setup
        var obj = new Multiple(input);

        var result = obj.IsMultofThree();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMultiple5_Positive()
    {
        // Arrange
        const int input = 5;
        const bool expected = true;

        // Setup
        var obj = new Multiple(input);

        var result = obj.IsMultofFive();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMultiple5_Negative()
    {
        // Arrange
        const int input = 6;
        const bool expected = false;

        // Setup
        var obj = new Multiple(input);

        var result = obj.IsMultofFive();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMultiple35_Positive()
    {
        // Arrange
        const int input = 15;
        const bool expected = true;

        // Setup
        var obj = new Multiple(input);

        var result = obj.IsMultofThreeAndFive();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMultiple35_Negative()
    {
        // Arrange
        const int input = 16;
        const bool expected = false;

        // Setup
        var obj = new Multiple(input);

        var result = obj.IsMultofThreeAndFive();

        // Assert
        Assert.Equal(expected, result);
    }
}