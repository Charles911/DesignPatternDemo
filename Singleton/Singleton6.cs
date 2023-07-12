namespace Singleton;

/// <summary>
/// 单例模式6(线程安全)
/// </summary>
/// <remarks>
/// 如果不要属性，也不要延迟加载，可以直接写成如下
/// </remarks>
public sealed class Singleton6
{
    Singleton6() { }
    public static readonly Singleton6 Instance = new();
}