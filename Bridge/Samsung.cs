namespace Bridge;

/// <summary>
/// 三星牌电视机，重写基类的抽象方法
/// </summary>
public class Samsung : TV
{
    public override void On() => Console.WriteLine("三星牌电视机已经打开了");

    public override void Off() => Console.WriteLine("三星牌电视机已经关掉了");

    public override void TuneChannel() => Console.WriteLine("三星牌电视机换频道");
}