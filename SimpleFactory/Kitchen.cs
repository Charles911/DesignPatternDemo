namespace SimpleFactory;

public class Kitchen
{
    public static Food? Create(string type)
    {
        return type switch
        {
            "土豆肉丝" => new ShreddedPorkWithPotatoes(),
            "西红柿炒蛋" => new TomatoScrambledEggs(),
            _ => null,
        };
    }
}