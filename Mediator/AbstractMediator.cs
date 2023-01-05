namespace Mediator;

/// <summary>
/// 抽象中介者类
/// </summary>
public abstract class AbstractMediator
{
    protected AbstractCardPartner partnerA;
    protected AbstractCardPartner partnerB;

    public AbstractMediator(AbstractCardPartner a, AbstractCardPartner b)
    {
        partnerA = a;
        partnerB = b;
    }

    public abstract void AWin(int count);
    public abstract void BWin(int count);
}
