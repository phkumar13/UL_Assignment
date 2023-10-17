namespace FizzBuzzConsole;

public static class Extensions
{
    public static string FizzBuzz(this int a)
    {
        var m = new Multiple(a);
        return m.DisplayResultLine();
    }
}
