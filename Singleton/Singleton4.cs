namespace Singleton;

/// <summary>
/// 单例模式4(线程安全)
/// </summary>
/// <remarks>
/// 如果我首先用了该类执行了里面的静态方法，但是不用单例，这种写法也会给我们创建单例出来，即过早地创建单例，从而降低内存的使用效率。
/// C#静态构造函数有如下特性：
/// 1.类最多只能有一个静态构造函数（可与实例构造函数共存），且不能带参数
/// 2.静态构造函数不能有访问修饰符
/// 3.不能访问实例成员，因此也不能使用this访问器
/// 4.不能显式调用，系统自动调用
/// 5.只要使用到该类（写到该类）就会执行一个过程（先执行静态字段赋值语句，然后执行静态构造函数），而这一过程由.Net运行时保证只执行一次
/// </remarks>
public sealed class Singleton4
{
    private Singleton4() { }

    private static readonly Singleton4 instance = new();

    public static Singleton4 Instance
    {
        get { return instance; }
    }
}