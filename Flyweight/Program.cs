namespace Flyweight;

/// <summary>
/// 享元模式
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //定义外部状态，例如字母的位置等信息
        int extrinsicstate = 10;
        //初始化享元工厂
        var factory = new FlyweightFactory();

        var fa = factory.GetFlyweight("A");
        //把外部状态作为享元对象的方法调用参数
        fa!.Operation(--extrinsicstate);

        var fb = factory.GetFlyweight("B");
        fb!.Operation(--extrinsicstate);

        var fc = factory.GetFlyweight("C");
        fc!.Operation(--extrinsicstate);

        var fd = factory.GetFlyweight("D");
        fd!.Operation(--extrinsicstate);

        Console.WriteLine(extrinsicstate);
    }
}
