namespace State;

/// <summary>
/// Gold State意味着有利息状态
/// 具体状态类，实现抽象状态类的每个行为
/// </summary>
public class GoldState : State
{
    public GoldState(State state)
    {
        Balance = state.Balance;
        Account = state.Account;
        Interest = 0.05;
        LowerLimit = 1000.00;
        UpperLimit = 1000000.00;
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

    private void StateChangeCheck()
    {
        if (Balance < 0.0)
        {
            Account!.State = new RedState(this);
        }
        else if (Balance < LowerLimit)
        {
            Account!.State = new SilverState(this);
        }
    }
}