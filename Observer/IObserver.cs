namespace Observer;

/// <summary>
/// 订阅者接口
/// </summary>
public interface IObserver
{
    void ReceiveAndPrint(TenXun tenXun);
}
