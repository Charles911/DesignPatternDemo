namespace Decorator;

/// <summary>
/// 贴膜，即具体装饰者
/// </summary>
public class Sticker(Phone p) : Decorator(p)
{
    public override void Print()
    {
        base.Print();

        //添加新的行为
        AddSticker();
    }

    /// <summary>
    /// 新的行为
    /// </summary>
    public void AddSticker() => Console.WriteLine("现在苹果手机有贴膜了");
}
