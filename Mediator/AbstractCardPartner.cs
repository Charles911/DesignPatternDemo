namespace Mediator;

/// <summary>
/// 抽象牌友类
/// </summary>
public abstract class AbstractCardPartner
{
    protected AbstractCardPartner() => MoneyCount = 0;

    public int MoneyCount { get; set; }

    public abstract void ChangeCount(int count, AbstractMediator mediator);
}
