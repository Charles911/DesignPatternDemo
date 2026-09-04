namespace Vistor;

/// <summary>
/// 访问者模式
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        foreach (Element e in new ObjectStructure().Elements)
        {
            //每个元素接受访问者访问
            e.Accept(new ConcreteVistor());
        }
    }
}
