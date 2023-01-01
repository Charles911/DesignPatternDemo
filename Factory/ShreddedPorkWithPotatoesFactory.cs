namespace Factory;

public class ShreddedPorkWithPotatoesFactory : Kitchen
{
    public override Food Create()
    {
        return new ShreddedPorkWithPotatoes();
    }
}