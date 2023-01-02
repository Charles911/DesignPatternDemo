namespace Adapter;

/// <summary>
/// 三个孔的插头，也就是适配器模式中的目标(Target)角色
/// 对象适配
/// </summary>
public class ThreeHole
{
    /// <summary>
    /// 客户端需要的方法
    /// </summary>
    public virtual void Request()
    {
        //可以将一般实现放到这里
    }
}