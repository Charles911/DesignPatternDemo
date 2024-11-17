namespace Vistor;

public class ConcreteVistor : IVistor
{
    public void Visit(ElementA a) =>
       //再去调用元素的Accept方法
       a.Print();

    public void Visit(ElementB b) => b.Print();
}
