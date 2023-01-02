namespace Factory;

public class TomatoScrambledEggsFactory : Kitchen
{
    public override Food Create() => new TomatoScrambledEggs();
}