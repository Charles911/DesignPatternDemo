namespace Factory;

public class MincedMeatEggplantFactory : Kitchen
{
    public override Food Create() => new MincedMeatEggplant();
}