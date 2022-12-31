namespace Singleton;

/// <summary>
/// 单例模式1(线程不安全)
/// </summary>
/// <remarks>
/// 只能在单线程环境下使用，在多线程环境中有创建多个单例的风险
/// </remarks>
public sealed class Singleton1 //该类不能被继承
{
    //没有标明访问权限的类成员，默认为private
    //无法从外部创建实例
    Singleton1() { }
    //静态后备字段
    static Singleton1? instance;
    //静态属性（与静态后备字段对应）
    public static Singleton1 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
    }
}