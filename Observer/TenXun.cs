namespace Observer;

/// <summary>
/// 订阅号抽象类
/// </summary>
public abstract class TenXun(string symbol, string info)
{
    private readonly List<IObserver> observers = new();

    public string Symbol { get; set; } = symbol;
    public string Info { get; set; } = info;

    public void AddObserver(IObserver observer) => observers.Add(observer);

    public void RemoveObserver(IObserver observer) => observers.Remove(observer);

    public void Update()
    {
        foreach (var observer in observers)
        {
            observer.ReceiveAndPrint(this);
        }
    }
}
