namespace Mediator;

/// <summary>
/// 具体中介者类
/// </summary>
public class MediatorPater : AbstractMediator
{
    public MediatorPater(AbstractCardPartner a, AbstractCardPartner b) : base(a, b) { }

    public override void AWin(int count)
    {
        partnerA.MoneyCount += count;
        partnerB.MoneyCount -= count;
    }

    public override void BWin(int count)
    {
        partnerB.MoneyCount += count;
        partnerA.MoneyCount -= count;
    }
}
