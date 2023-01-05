namespace Mediator;

/// <summary>
/// 牌友A
/// </summary>
public class ParterA : AbstractCardPartner
{
    /// <summary>
    /// 依赖与抽象中介者对象
    /// </summary>
    /// <param name="count"></param>
    /// <param name="mediator"></param>
    public override void ChangeCount(int count, AbstractMediator mediator) =>
        mediator.AWin(count);
}