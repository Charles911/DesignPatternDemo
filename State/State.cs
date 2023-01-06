namespace State;

/// <summary>
/// 抽象状态类
/// </summary>
/// <remarks>
/// 定义了一个具体状态类需要实现的行为约定。
/// </remarks>
public abstract class State
{
    public Account? Account { get; set; }
    public double Balance { get; set; } //余额
    public double Interest { get; set; } //利率
    public double LowerLimit { get; set; } //下限
    public double UpperLimit { get; set; } //上限

    /// <summary>
    /// 存款
    /// </summary>
    /// <param name="amount"></param>
    public abstract void Deposit(double amount);

    /// <summary>
    /// 取款
    /// </summary>
    /// <param name="amount"></param>
    public abstract void Withdraw(double amount);

    /// <summary>
    /// 利息
    /// </summary>
    public abstract void PayInterest();
}