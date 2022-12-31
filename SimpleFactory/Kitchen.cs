namespace SimpleFactory;

public class Kitchen
{
    public static Food? Create(string type)
    {
        switch (type)
        {
            case "土豆肉丝":
                return new ShreddedPorkWithPotatoes();
            case "西红柿炒蛋":
                return new TomatoScrambledEggs();
            default:
                return null;
        }
    }
}