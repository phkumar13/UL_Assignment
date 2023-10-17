using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FactorialConsole;

/// <summary>
/// Display a list of numbers via the console from one to one-hundred and given the following conditions;
/// Number is a multiple of 3 : Output the number + "Fizz".
/// Number is a multiple of 5 : Output the number + "Buzz".
/// Number is a multiple of both : Output the number + "FizzBuzz".
/// Number is not a multiple of 3/5 : Ouput the number alone.
/// </summary>
static class Program
{
    static void Main()
    {
        try
        {
            long number = -1;

            Console.Write("Please enter the number to calculate the factorial : ");
            string? inputNumber = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputNumber))
            {
                number = long.Parse(s: inputNumber);
            }

            Console.WriteLine(FactorialUtil.GetFactorial(number));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Your factorial.  Sorry.");
            Console.WriteLine("Message: " + ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Any key to exit >>");
        Console.ReadKey();
    }
}
