namespace Decorator;

/// <summary>
/// 苹果手机，即装饰着模式中的具体组件类
/// </summary>
public class ApplePhone : Phone
{
    /// <summary>
    /// 重写基类方法
    /// </summary>
    public override void Print() => Console.WriteLine("开始执行具体的对象——苹果手机");
}