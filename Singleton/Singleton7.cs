namespace Singleton;

public sealed class Singleton7
{
    private static readonly Lazy<Singleton7> lazy =
           new(()=> new Singleton7());

    public static Singleton7 Instance { get { return lazy.Value; } }

    private Singleton7() { }
}