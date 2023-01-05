namespace Decorator;

/// <summary>
/// 装饰者模式
/// 装饰者模式以对客户透明的方式动态地给一个对象附加上更多的责任，装饰者模式相比生成子类可以更灵活地增加功能
/// </summary>
/// <remarks>
/// 优点：
/// 1.装饰这模式和继承的目的都是扩展对象的功能，但装饰者模式比继承更灵活
/// 2.通过使用不同的具体装饰类以及这些类的排列组合，设计师可以创造出很多不同行为的组合
/// 3.装饰者模式有很好地可扩展性
/// 
/// 缺点：
/// 1.装饰者模式会导致设计中出现许多小对象，如果过度使用，会让程序变的更复杂。并且更多的对象会是的查错变得困难，特别是这些对象看上去都很像。
/// 
/// 使用场景:
/// 1.需要扩展一个类的功能或给一个类增加附加责任。
/// 2.需要动态地给一个对象增加功能，这些功能可以再动态地撤销。
/// 3.需要增加由一些基本功能的排列组合而产生的非常大量的功能
/// </remarks>
class Program
{
    static void Main(string[] args)
    {
        var phone = new ApplePhone();

        var applePhoneWithSticker = new Sticker(phone);
        applePhoneWithSticker.Print();
        Console.WriteLine("-------------------------");

        var applePhoneWithAccessories = new Accessories(phone);
        applePhoneWithAccessories.Print();
        Console.WriteLine("-------------------------");

        var sticker = new Sticker(phone);
        var applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
        applePhoneWithAccessoriesAndSticker.Print();
    }
}
