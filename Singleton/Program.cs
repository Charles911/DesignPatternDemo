namespace Singleton;
class Program
{
    static void Main(string[] args)
    {
        var s7 = Singleton7.Instance;
        Console.WriteLine(s7.ToString());
    }
}
