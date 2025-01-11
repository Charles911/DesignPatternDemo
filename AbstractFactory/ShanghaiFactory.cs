namespace AbstractFactory;

public class ShanghaiFactory : AbstractFactory
{
    public override DuckNeck CreateYabo() => new ShanghaiDuckNeck();

    public override DuckRack CreateYajia() => new ShanghaiDuckRack();
}