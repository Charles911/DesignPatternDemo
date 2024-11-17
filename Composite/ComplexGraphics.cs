namespace Composite;

/// <summary>
/// 复杂图形，由一些简单图形组成, 这里假设该复杂图形由一个圆两条线组成的复杂图形
/// </summary>
public class ComplexGraphics(string name) : Graphics(name)
{
    private readonly List<Graphics> complexGraphicses = new();

    /// <summary>
    /// 复杂图形的画法
    /// </summary>
    public override void Draw()
    {
        foreach (var g in complexGraphicses)
        {
            g.Draw();
        }
    }

    public void Add(Graphics g)
    {
        complexGraphicses.Add(g);
    }

    public void Remove(Graphics g)
    {
        complexGraphicses.Remove(g);
    }
}