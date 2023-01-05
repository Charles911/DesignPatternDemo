namespace Command;

/// <summary>
/// 教官，负责调用命令对象执行请求
/// </summary>
public class Invoke
{
    public Command _command;

    public Invoke(Command command) => _command = command;

    public void Execute() => _command.Action();
}
