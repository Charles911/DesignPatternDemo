namespace Decorator;

/// <summary>
/// 装饰抽象类,要让装饰完全取代抽象组件，所以必须继承自Phone
/// </summary>
public class Decorator(Phone p) : Phone
{
    private readonly Phone phone = p;

    public override void Print()
    {
        phone?.Print();
    }
}
