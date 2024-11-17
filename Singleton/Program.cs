namespace Singleton;

internal class Program
{
    private static void Main()
    {
        var s7 = Singleton7.Instance;
        Console.WriteLine(s7.ToString());
    }
}
