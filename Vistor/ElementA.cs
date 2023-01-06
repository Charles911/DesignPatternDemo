namespace Vistor;

/// <summary>
/// 具体元素A
/// </summary>
public class ElementA : Element
{
    public override void Accept(IVistor vistor)
    {
        //调用访问者方法
        vistor.Visit(this);
    }

    public override void Print() => Console.WriteLine($"我是元素{this}");
}
