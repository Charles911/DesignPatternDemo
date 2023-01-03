namespace Facade;

/// <summary>
/// 课程注册子系统
/// </summary>
public class RegisterCourse
{
    public bool CheckAvailable(string courseName)
    {
        Console.WriteLine($"正在验证课程{courseName}是否人数已满");
        return true;
    }
}