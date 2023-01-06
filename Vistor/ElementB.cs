namespace Vistor;

/// <summary>
/// 具体元素B
/// </summary>
public class ElementB : Element
{
    public override void Accept(IVistor vistor)
    {
        vistor.Visit(this);
    }

    public override void Print() => Console.WriteLine($"我是元素{this}");
}
