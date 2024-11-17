namespace Composite;

/// <summary>
/// 图形抽象类
/// </summary>
public abstract class Graphics(string name)
{
    public string Name { get; set; } = name;

    public abstract void Draw();
}