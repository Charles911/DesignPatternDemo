namespace Vistor;

/// <summary>
/// 访问者接口
/// </summary>
public interface IVistor
{
    void Visit(ElementA a);
    void Visit(ElementB b);
}
