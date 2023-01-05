namespace Composite;

/// <summary>
/// 图形抽象类
/// </summary>
public abstract class Graphics
{
    protected Graphics(string name) => Name = name;

    public string Name { get; set; }

    public abstract void Draw();
}