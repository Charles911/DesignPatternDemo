namespace Observer;

/// <summary>
/// 具体的订阅者类
/// </summary>
public class Subscriber(string name) : IObserver
{
    public string Name { get; set; } = name;

    public void ReceiveAndPrint(TenXun tenXun)
    {
        Console.WriteLine($"Notified {Name} of {tenXun.Symbol}'s Info is: {tenXun.Info}");
    }
}
