namespace Adapter;

/// <summary>
/// 适配器类，这里适配器类没有TwoHole类，
/// 而是引用了TwoHole对象，所以是对象的适配器模式的实现
/// 对象适配模式
/// </summary>
public class PowerAdapter2: ThreeHole
{
    TwoHole twoHole = new TwoHole();

    /// <summary>
    /// 实现三个孔插头接口方法
    /// </summary>
    public override void Request()
    {
        base.Request();
        twoHole.SpecificRequest();
    }
}