namespace Decorator;

/// <summary>
/// 手机挂件
/// </summary>
public class Accessories(Phone p) : Decorator(p)
{
    public override void Print()
    {
        base.Print();

        //添加新的行为
        AddAccessories();
    }

    /// <summary>
    /// 新的行为
    /// </summary>
    public void AddAccessories() => Console.WriteLine("现在苹果手机有漂亮的挂件了");
}
