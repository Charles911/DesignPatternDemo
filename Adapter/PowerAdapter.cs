namespace Adapter;

/// <summary>
/// 适配器类，接口要放在类的后面
/// 适配器类提供了三个孔插头的行为，但其本质是调用两个孔插头的方法
/// 类适配模式
/// </summary>
public class PowerAdapter : TwoHole, IThreeHole
{
    /// <summary>
    /// 实现三个孔插头接口方法
    /// </summary>
    public void Request() => this.SpecificRequest(); ////调用两个孔插头方法
}