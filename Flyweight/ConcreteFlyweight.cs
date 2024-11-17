namespace Flyweight;

/// <summary>
/// 具体的享元对象，这样我们不把每个字母设计成一个单独的类了，而是作为把共享的字母作为享元对象的内部状态
/// </summary>
/// <remarks>
/// 构造方法
/// </remarks>
/// <param name="innerState"></param>
public class ConcreteFlyweight(string innerState) : Flyweight
{
    //内部状态
    private readonly string intrinsicstate = innerState;

    /// <summary>
    /// 享元类的实例方法
    /// </summary>
    /// <param name="extrinsicstate">外部状态</param>
    public override void Operation(int extrinsicstate) =>
        Console.WriteLine($"具体实现类：intrinsicstate {intrinsicstate} extrinsicstate {extrinsicstate}");
}