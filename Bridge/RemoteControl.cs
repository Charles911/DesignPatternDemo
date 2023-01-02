namespace Bridge;

/// <summary>
/// 抽象概念中的遥控器，扮演抽象化角色
/// </summary>
public class RemoteControl
{
    public TV? Implementor { get; set; }

    /// <summary>
    /// 开电视机，这里抽象类中不再提供实现了，而是调用实现类中的实现
    /// </summary>
    public virtual void On() => Implementor!.On();

    /// <summary>
    /// 关电视机
    /// </summary>
    public virtual void Off() => Implementor!.Off();

    /// <summary>
    /// 换频道
    /// </summary>
    public virtual void SetChannel() => Implementor!.TuneChannel();
}