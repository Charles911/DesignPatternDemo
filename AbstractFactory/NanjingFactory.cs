namespace AbstractFactory;

public class NanjingFactory : AbstractFactory
{
    public override DuckNeck CreateYabo() => new NanjingDuckNeck();

    public override DuckRack CreateYajia() => new NanjingDuckRack();
}