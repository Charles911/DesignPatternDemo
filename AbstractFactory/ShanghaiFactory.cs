namespace AbstractFactory;

public class ShanghaiFactory : AbstractFactory
{
    public override Yabo CreateYabo() => new ShanghaiYabo();

    public override Yajia CreateYajia() => new ShanghaiYajia();
}