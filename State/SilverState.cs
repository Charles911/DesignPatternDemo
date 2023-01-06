namespace State;

/// <summary>
/// Silver State意味着没有利息得
/// 具体状态类，实现抽象状态类的每个行为
/// </summary>
public class SilverState : State
{
    public SilverState(State state) : this(state.Balance, state.Account!) { }

    public SilverState(double balance, Account account)
    {
        Balance = balance;
        Account = account;
        Interest = 0.00;
        LowerLimit = 0.00;
        UpperLimit = 1000.00;
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
    /// 利息
    /// </summary>
    public override void PayInterest()
    {
        Balance += Interest * Balance;
        StateChangeCheck();
    }

    /// <summary>
    /// 取款
    /// </summary>
    /// <param name="amount"></param>
    public override void Withdraw(double amount)
    {
        Balance -= amount;
        StateChangeCheck();
    }

    void StateChangeCheck()
    {
        if (Balance < LowerLimit)
        {
            Account!.State = new RedState(this);
        }
        else if (Balance > UpperLimit)
        {
            Account!.State = new GoldState(this);
        }
    }
}