namespace Bridge;

/// <summary>
/// 长虹牌电视机，重写基类的抽象方法
/// 提供具体的实现
/// </summary>
public class ChangHong : TV
{
    public override void On() => Console.WriteLine("长虹牌电视机已经打开了");

    public override void Off() => Console.WriteLine("长虹牌电视机已经关掉了");

    public override void TuneChannel() => Console.WriteLine("长虹牌电视机换频道");
}