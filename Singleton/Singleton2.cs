namespace Singleton;

/// <summary>
/// 单例模式2(线程安全)
/// </summary>
/// <remarks>
/// 可以保证在多线程中只有一个单例，但时间效率不高
/// 反复上锁，而加锁是一个非常耗时的操作，在没有必要的时候应该尽量避免
/// </remarks>
public sealed class Singleton2
{
    Singleton2() { }
    static Singleton2? instance;
    //同步锁
    static readonly object syncObj = new();
    public static Singleton2 Instance
    {
        get
        {
            //请求锁定同步对象（只能锁引用类型）
            lock (syncObj)
            {
                //当其他线程发现对象被锁定了，只能等待
                instance ??= new Singleton2();
            }
            return instance;
        }
    }
}