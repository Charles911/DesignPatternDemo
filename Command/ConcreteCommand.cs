namespace Command;

/// <summary>
/// 具体命令类
/// </summary>
public class ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver) : base(receiver) { }

    public override void Action() => _receiver.Run(); //调用接收的方法，因为执行命令的是学生
}