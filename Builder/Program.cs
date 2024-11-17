namespace Builder;

/// <summary>
/// 建造者模式
/// </summary>
/// <remarks>
/// 以组装电脑为例子
/// 每台电脑的组成过程都是一致的，但是使用同样的构建过程可以创建不同的表示(即可以组装成不一样的电脑，配置不一样)
/// 组装电脑的这个场景就可以应用建造者模式来设计
/// 
/// 建造者模式（Builder Pattern）:将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
/// 建造者模式使得建造代码与表示代码的分离，可以使客户端不必知道产品内部组成的细节，从而降低了客户端与具体产品之间的耦合度。
/// </remarks>
internal class Program
{
    private static void Main(string[] args)
    {
        //客户找到电脑城老板说要买电脑，这里要装两台电脑
        //创建指挥者和构造者
        var director = new Director();
        var builder1 = new ConcreteBuilder1();
        var builder2 = new ConcreteBuilder2();

        //老板叫员工去组装第一台电脑
        director.Construct(builder1);

        //组装完，组装人员搬来组装好的电脑
        var computer1 = builder1.GetComputer();
        computer1.Show();

        //老板叫员工去组装第二台电脑
        director.Construct(builder2);

        //组装完，组装人员搬来组装好的电脑
        var computer2 = builder2.GetComputer();
        computer2.Show();
    }
}
