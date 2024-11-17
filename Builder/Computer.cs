namespace Builder;

/// <summary>
/// 电脑类
/// </summary>
public class Computer
{
    //电脑组件集合
    public IList<string> parts = [];

    //把单个组件添加到电脑组件集合中
    public void Add(string part) => parts.Add(part);

    public void Show()
    {
        Console.WriteLine("电脑开始组装……");

        foreach (var part in parts)
        {
            Console.WriteLine($"组件{part}已装好");
        }

        Console.WriteLine("电脑组装好了");
    }
}