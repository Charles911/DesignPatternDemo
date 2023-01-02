namespace AbstractFactory;

public class NanjingFactory : AbstractFactory
{
    public override Yabo CreateYabo() => new NanjingYabo();

    public override Yajia CreateYajia() => new NanjingYajia();
}