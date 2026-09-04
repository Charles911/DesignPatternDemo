namespace SimpleFactory;

/// <summary>
/// 简单工厂模式
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        var food1 = Kitchen.Create("土豆肉丝");
        var food2 = Kitchen.Create("西红柿炒蛋");

        food1!.Show();
        food2!.Show();
    }
}
