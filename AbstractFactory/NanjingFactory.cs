namespace AbstractFactory;

public class NanjingFactory : AbstractFactory
{
    public override Yabo CreateYabo()
    {
        return new NanjingYabo();
    }

    public override Yajia CreateYajia()
    {
        return new NanjingYajia();
    }
}