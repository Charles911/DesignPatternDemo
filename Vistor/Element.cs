namespace Vistor;

/// <summary>
/// 抽象元素角色
/// </summary>
public abstract class Element
{
    public abstract void Accept(IVistor vistor);
    public abstract void Print();
}
