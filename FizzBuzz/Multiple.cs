namespace FizzBuzzConsole;

/// <summary>
/// Manages operations for a value we want to determine multiples for.
/// </summary>
public class Multiple
{
    private int EvalNumber { get; set; }

    public Multiple(int number)
    {
        EvalNumber = number;
    }

    public bool IsMultofThree()
    {
        return (EvalNumber % 3) == 0;
    }

    public bool IsMultofFive()
    {
        return (EvalNumber % 5) == 0;
    }

    public bool IsMultofThreeAndFive()
    {
        return (IsMultofThree() && IsMultofFive());
    }

    public string DisplayResultLine()
    {
        if (IsMultofThreeAndFive())
            return String.Format("{0:000} FizzBuzz", EvalNumber);

        if (IsMultofFive())
            return String.Format("{0:000} Buzz", EvalNumber);

        if (IsMultofThree())
            return String.Format("{0:000} Fizz", EvalNumber);

        return String.Format("{0:000}", EvalNumber);
    }
}
