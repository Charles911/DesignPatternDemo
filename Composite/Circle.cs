namespace Composite;

/// <summary>
/// 简单图形类——圆
/// </summary>
public class Circle(string name) : Graphics(name)
{
    public override void Draw() => Console.WriteLine($"画 {Name}");
}