namespace State;

/// <summary>
/// Red State意味着Account透支了
/// 具体状态类，实现抽象状态类的每个行为
/// </summary>
public class RedState : State
{
    public RedState(State state)
    {
        Balance = state.Balance;
        Account = state.Account;
        Interest = 0.00;
        LowerLimit = -100.00;
        UpperLimit = 0.00;
    }

    /// <summary>
    /// 存款
    /// </summary>
    /// <param name="amount"></param>
    public override void Deposit(double amount)
    {
        Balance += amount;
        StateChangeCheck();
    }

    /// <summary>
    /// 没有利息
    /// </summary>
    public override void PayInterest() { }

    /// <summary>
    /// 取款
    /// </summary>
    /// <param name="amount"></param>
    public override void Withdraw(double amount) => Console.WriteLine("没有钱可以取了！");

    void StateChangeCheck()
    {
        if (Balance > UpperLimit)
        {
            Account!.State = new SilverState(this);
        }
    }
}