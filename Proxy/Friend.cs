namespace Proxy;

/// <summary>
/// 代理角色
/// </summary>
public class Friend : Person
{
    //引用真实主题
    RealBuyPerson? realBuyPerson;

    public override void BuyProduct()
    {
        Console.WriteLine("通过代理类访问真是实体类对象的方法");

        if (realBuyPerson == null)
        {
            realBuyPerson = new RealBuyPerson();
        }

        PreBuyProduct();
        //调用真实主题方法
        realBuyPerson.BuyProduct();
        PostBuyProduct();
    }

    /// <summary>
    /// 事前准备工作
    /// </summary>
    void PreBuyProduct() =>
        Console.WriteLine("我怕弄糊涂了，需要列一张清单，张三：要带相机，李四：要带Iphone...........");

    /// <summary>
    /// 收尾工作
    /// </summary>
    void PostBuyProduct() =>
        Console.WriteLine("终于买完了，现在要对东西分一下，相机是张三的；Iphone是李四的..........");
}