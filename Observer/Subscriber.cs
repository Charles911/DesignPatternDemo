namespace Observer;

/// <summary>
/// 具体的订阅者类
/// </summary>
public class Subscriber : IObserver
{
    public Subscriber(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void ReceiveAndPrint(TenXun tenXun)
    {
        Console.WriteLine($"Notified {Name} of {tenXun.Symbol}'s Info is: {tenXun.Info}");
    }
}
