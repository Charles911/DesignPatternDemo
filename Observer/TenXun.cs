namespace Observer;

/// <summary>
/// 订阅号抽象类
/// </summary>
public abstract class TenXun
{
    List<IObserver> observers = new();

    protected TenXun(string symbol, string info)
    {
        Symbol = symbol;
        Info = info;
    }

    public string Symbol { get; set; }
    public string Info { get; set; }

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
