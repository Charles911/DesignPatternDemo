namespace Prototype;

/// <summary>
/// 孙悟空原型
/// </summary>
public abstract class MonkeyKingPrototype
{
    public string Id { get; set; }

    public MonkeyKingPrototype(string id)
    {
        Id = id;
    }

    /// <summary>
    /// 克隆方法，即孙大圣说“变”
    /// </summary>
    /// <returns></returns>
    public abstract MonkeyKingPrototype Clone();
}