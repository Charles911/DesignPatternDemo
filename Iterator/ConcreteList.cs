namespace Iterator;

/// <summary>
/// 具体聚合类
/// </summary>
public class ConcreteList : IListCollection
{
    private readonly int[] collection;

    public ConcreteList() => collection = [2, 4, 6, 8];

    public Iterator GetIterator() => new ConcreteIterator(this);

    public int Length
    {
        get => collection.Length;
    }

    public int GetElement(int index) => collection[index];
}
