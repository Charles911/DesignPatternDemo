namespace Flyweight;

/// <summary>
/// 抽象享元类，提供具体享元类具有的方法
/// </summary>
public abstract class Flyweight
{
    public abstract void Operation(int extrinsicstate);
}