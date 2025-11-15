namespace Iterator;

/// <summary>
/// 迭代器模式
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Iterator iterator = new ConcreteList().GetIterator();

        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.GetCurrent());
            iterator.Next();
        }
    }
}
