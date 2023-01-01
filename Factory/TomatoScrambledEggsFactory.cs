namespace Factory;

public class TomatoScrambledEggsFactory : Kitchen
{
    public override Food Create()
    {
        return new TomatoScrambledEggs();
    }
}