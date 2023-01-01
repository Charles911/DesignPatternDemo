namespace Factory;
class Program
{
    static void Main(string[] args)
    {
        var factory1 = new TomatoScrambledEggsFactory();
        var factory2 = new ShreddedPorkWithPotatoesFactory();
        var factory3 = new MincedMeatEggplantFactory();

        var food1 = factory1.Create();
        var food2 = factory2.Create();
        var food3 = factory3.Create();

        food1.Show();
        food2.Show();
        food3.Show();
    }
}
