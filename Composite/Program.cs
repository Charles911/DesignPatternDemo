namespace Composite;

/// <summary>
/// 组合模式
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        var complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
        complexGraphics.Add(new Line("线段A"));
        var compositeCG = new ComplexGraphics("一个圆和一条线组成的复杂图形");
        compositeCG.Add(new Circle("圆"));
        compositeCG.Add(new Circle("线段B"));
        complexGraphics.Add(compositeCG);
        var line = new Line("线段C");
        complexGraphics.Add(line);

        // 显示复杂图形的画法
        Console.WriteLine("复杂图形的绘制如下：");
        Console.WriteLine("---------------------");
        complexGraphics.Draw();
        Console.WriteLine("复杂图形绘制完成");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        // 移除一个组件再显示复杂图形的画法
        complexGraphics.Remove(line);
        Console.WriteLine("移除线段C后，复杂图形的绘制如下：");
        Console.WriteLine("---------------------");
        complexGraphics.Draw();
        Console.WriteLine("复杂图形绘制完成");
        Console.WriteLine("---------------------");
    }
}
