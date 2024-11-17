namespace Prototype;

/// <summary>
/// 创建具体原型
/// </summary>
public class ConcretePrototype(string id) : MonkeyKingPrototype(id)
{

    /// <summary>
    /// 浅拷贝
    /// </summary>
    /// <returns></returns>
    public override MonkeyKingPrototype Clone() => (MonkeyKingPrototype)MemberwiseClone();
}