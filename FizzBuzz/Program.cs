namespace FizzBuzzConsole;

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
            Console.WriteLine(StaticMethods.FizzBuzzRange(1, 100));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Your fizzbuzz fizzed and buzzed.  Sorry.");
            Console.WriteLine("Message: " + ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Any key to exit >>");
        Console.ReadKey();
    }
}
