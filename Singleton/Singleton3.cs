namespace Singleton;

/// <summary>
/// 单例模式3(线程安全)
/// </summary>
/// <remarks>
/// 在创建多个单例的时候加上同步锁
/// 可行，但嵌套多
/// </remarks>
public sealed class Singleton3
{
    private Singleton3() { }

    private static Singleton3? instance;
    private static readonly object syncObj = new();
    public static Singleton3 Instance
    {
        get
        {
            //加上判断，只需要在没有创建实例时加锁
            if (instance == null)
            {
                lock (syncObj)
                {
                    instance ??= new Singleton3();
                }
            }
            return instance;
        }
    }
}