namespace Mediator;

/// <summary>
/// 抽象中介者类
/// </summary>
public abstract class AbstractMediator(AbstractCardPartner a, AbstractCardPartner b)
{
    protected AbstractCardPartner partnerA = a;
    protected AbstractCardPartner partnerB = b;

    public abstract void AWin(int count);
    public abstract void BWin(int count);
}
