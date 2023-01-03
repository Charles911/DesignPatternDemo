namespace Proxy;

/// <summary>
/// 真实主题角色
/// </summary>
public class RealBuyPerson : Person
{
    public override void BuyProduct() => Console.WriteLine("帮我买一个iPhone和一台iMac");
}