namespace Composite;

/// <summary>
/// 简单图形类——圆
/// </summary>
public class Circle : Graphics
{
    public Circle(string name) : base(name) { }

    public override void Draw() => Console.WriteLine($"画 {Name} 图");
}