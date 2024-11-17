namespace Command;

/// <summary>
/// 教官，负责调用命令对象执行请求
/// </summary>
public class Invoke(Command command)
{
    public Command _command = command;

    public void Execute() => _command.Action();
}
