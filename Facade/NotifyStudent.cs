namespace Facade;

/// <summary>
/// 学生通知子系统
/// </summary>
public class NotifyStudent
{
    public bool Notify(string studentName)
    {
        Console.WriteLine($"正在向{studentName}发送通知");
        return true;
    }
}