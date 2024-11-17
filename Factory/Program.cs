namespace Factory;

/// <summary>
/// 工厂模式
/// </summary>
/// <remarks>
/// 工厂方法模式通过面向对象编程中的多态性来将对象的创建延迟到具体工厂中，从而解决了简单工厂模式中存在的问题，也很好地符合了开放封闭原则（即对扩展开发，对修改封闭）。
/// </remarks>
internal class Program
{
    private static void Main(string[] args)
    {
        var factory1 = new TomatoScrambledEggsFactory();
        var factory2 = new ShreddedPorkWithPotatoesFactory();
        var factory3 = new MincedMeatEggplantFactory();

        var food1 = factory1.Create();
        var food2 = factory2.Create();
        var food3 = factory3.Create();

        food1.Show();
        food2.Show();
        food3.Show();
    }
}
