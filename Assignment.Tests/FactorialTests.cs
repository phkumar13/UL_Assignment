using FactorialConsole;

namespace FactorialTests;

public class Factorial
{
    [Fact]
    public void TestFactorialOf0Is1()
    {
        //exercise
        long result = FactorialUtil.GetFactorial(0);

        //verification
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestFactorialOf1Is1()
    {
        //exercise
        long result = FactorialUtil.GetFactorial(1);

        //verification
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestFactorialOfXIsXTimesXMin1Fact()
    {
        //exercise
        for (long x = 2; x < 20; x++)
        {
            long result = FactorialUtil.GetFactorial(x);
            Console.WriteLine("{0}! = {1}", x, result);

            //verification
            Assert.Equal(x * FactorialUtil.GetFactorial(x - 1), result);
        }
    }

    [Fact]
    public void TestFactorialResultCannotBeNegative()
    {
        //exercise
        try
        {
            long result = FactorialUtil.GetFactorial(24);
            Assert.Fail("Factorial Result Cannot Be Negative");
            Console.WriteLine("{0}! = {1}", 24, result);
        }
        catch (Exception fe)
        {
            Assert.Equal(typeof(FactorialException), fe.GetType());
        }
    }
}
