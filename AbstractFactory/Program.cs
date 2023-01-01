namespace AbstractFactory;

/// <summary>
/// 抽象工厂模式
/// </summary>
/// <remarks>
/// 优点：
/// 抽象工厂对于系列产品的变化支持 “开放——封闭”原则（指的是要求系统对扩展开放，对修改封闭），扩展起来非常简便
/// 缺点：
/// 抽象工厂模式很难支持新种类产品的变化。
/// 这是因为抽象工厂接口中已经确定了可以被创建的产品集合，如果需要添加新产品，此时就必须去修改抽象工厂的接口，这样就涉及到抽象工厂类的以及所有子类的改变，这样也就违背了“开发——封闭”原则。
/// </remarks>
class Program
{
    static void Main(string[] args)
    {
        var af1 = new NanjingFactory();
        var af2 = new ShanghaiFactory();

        var sYb = af2.CreateYabo();
        var nYb = af1.CreateYabo();
        var sYj = af2.CreateYajia();
        var nYj = af1.CreateYajia();

        sYb.Show();
        nYb.Show();
        sYj.Show();
        nYj.Show();
    }
}
