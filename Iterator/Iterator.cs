namespace Iterator;

/// <summary>
/// 迭代器抽象类
/// </summary>
public interface Iterator
{
    bool MoveNext();
    Object GetCurrent();
    void Next();
    void Reset();
}
