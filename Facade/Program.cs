namespace Facade;

internal class Program
{
    private static readonly RegistrationFacade facade = new();

    private static void Main(string[] args)
    {
        if (facade.RegisterCourse("设计模式", "Learning Hard"))
        {
            Console.WriteLine("选课成功");
        }
        else
        {
            Console.WriteLine("选课失败");
        }
    }
}
