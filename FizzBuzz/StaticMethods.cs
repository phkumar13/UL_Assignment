using System.Text;

namespace FizzBuzzConsole;

public static class StaticMethods
{
    /// <summary>
    /// Main program loop, to print a range from x to y.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>Formatted output string.</returns>
    public static string FizzBuzzRange(int start, int end)
    {
        Console.Write(PrintHeader());

        var outputBlock = new StringBuilder();

        for (var a = start; a <= end; a++)
        {
            outputBlock.AppendLine(a.FizzBuzz());
        }

        return outputBlock.ToString();
    }

    public static string PrintHeader()
    {
        var header = new StringBuilder();
        header.AppendLine("Fizz: Multiple of 3.");
        header.AppendLine("Buzz: Multiple of 5.");
        header.AppendLine("FizzBuzz: Multiple of both 3 and 5.");
        header.AppendLine();
        return header.ToString();
    }
}
