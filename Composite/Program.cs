namespace Composite;

/// <summary>
/// 通过一些简单图形以及一些复杂图形构建图形树来演示组合模式
/// 客户端调用
/// </summary>
/// <remarks>
/// 优点：
/// 1.组合模式使得客户端代码可以一致地处理对象和对象容器，无需关系处理的单个对象，还是组合的对象容器。
/// 2.将”客户代码与复杂的对象容器结构“解耦。
/// 3.可以更容易地往组合对象中加入新的构件。
/// 
/// 缺点：
/// 1.使得设计更加复杂。客户端需要花更多时间理清类之间的层次关系。（这个是几乎所有设计模式所面临的问题）。
/// 
/// 注意的问题：
/// 1.有时候系统需要遍历一个树枝结构的子构件很多次，这时候可以考虑把遍历子构件的结构存储在父构件里面作为缓存。
/// 2.客户端尽量不要直接调用树叶类中的方法（在我上面实现就是这样的，创建的是一个树枝的具体对象，应该使用Graphics complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");），而是借用其父类（Graphics）的多态性完成调用，这样可以增加代码的复用性。
/// 
/// 在以下情况下应该考虑使用组合模式：
/// 1.需要表示一个对象整体或部分的层次结构。
/// 2.希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象。
/// </remarks>
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
