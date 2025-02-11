namespace Composite;

/// <summary>
/// 简单图形类——线
/// </summary>
public class Line(string name) : Graphics(name)
{

    /// <summary>
    /// 重写父类抽象方法
    /// </summary>
    public override void Draw() => Console.WriteLine($"画 {Name}");
}