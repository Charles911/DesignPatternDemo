namespace Command;

/// <summary>
/// 命令抽象类
/// </summary>
public abstract class Command(Receiver receiver)
{
    //命令应该知道接收者是谁，所以有Receiver这个成员变量
    protected Receiver _receiver = receiver;

    /// <summary>
    /// 命令执行方法
    /// </summary>
    public abstract void Action();
}
