namespace State;

/// <summary>
/// Account类
/// </summary>
/// <remarks>
/// 维护一个State类的一个实例，该实例标识着当前对象的状态。
/// </remarks>
public class Account
{
    //State类实例
    public State State { get; set; }
    public string Owner { get; set; }

    public Account(string owner)
    {
        Owner = owner;
        State = new SilverState(0.0, this);
    }

    public double Balance { get => State.Balance; }

    /// <summary>
    /// 存款
    /// </summary>
    /// <param name="amount"></param>
    public void Deposit(double amount)
    {
        State.Deposit(amount);
        Console.WriteLine($"存款金额为：{amount:C}");
        Console.WriteLine($"账户余额为：{Balance:C}");
        Console.WriteLine($"账户状态为：{State.GetType().Name:C}");
        Console.WriteLine("-----------------------------------");
    }

    /// <summary>
    /// 取款
    /// </summary>
    /// <param name="amount"></param>
    public void Withdraw(double amount)
    {
        State.Withdraw(amount);
        Console.WriteLine($"取款金额为：{amount:C}");
        Console.WriteLine($"账户余额为：{Balance:C}");
        Console.WriteLine($"账户状态为：{State.GetType().Name:C}");
        Console.WriteLine("-----------------------------------");
    }

    /// <summary>
    /// 利息
    /// </summary>
    public void PayInterest()
    {
        State.PayInterest();
        Console.WriteLine($"支付利息");
        Console.WriteLine($"账户余额为：{Balance:C}");
        Console.WriteLine($"账户状态为：{State.GetType().Name:C}");
        Console.WriteLine("-----------------------------------");
    }
}