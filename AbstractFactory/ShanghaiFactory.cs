namespace AbstractFactory;

public class ShanghaiFactory : AbstractFactory
{
    public override Yabo CreateYabo()
    {
        return new ShanghaiYabo();
    }

    public override Yajia CreateYajia()
    {
        return new ShanghaiYajia();
    }
}