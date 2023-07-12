namespace Singleton;

/// <summary>
/// 单例模式5(线程安全)
/// </summary>
/// <remarks>
/// 这种解法能实现按需创建单例，当然，如果单例较大，用Lazy也是可以的。
/// </remarks>
public sealed class Singleton5
{
    Singleton5() { }
    public static Singleton5 Instance
    {
        //只有真正的用到单例才会执行嵌套类的静态构造函数
        get { return Nested.instance; }
    }

    /// <summary>
    /// 私有嵌套类
    /// </summary>
    class Nested
    {
        internal static readonly Singleton5 instance = new();
    }
}