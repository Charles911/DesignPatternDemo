namespace Prototype;

/// <summary>
/// 孙悟空原型
/// </summary>
public abstract class MonkeyKingPrototype(string id)
{
    public string Id { get; set; } = id;

    /// <summary>
    /// 克隆方法，即孙大圣说“变”
    /// </summary>
    /// <returns></returns>
    public abstract MonkeyKingPrototype Clone();
}