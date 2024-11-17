﻿namespace Mediator;

/// <summary>
/// 中介者模式
/// </summary>
/// <remarks>
/// 中介者模式，定义了一个中介对象来封装一系列对象之间的交互关系。
/// 中介者使各个对象之间不需要显式地相互引用，从而使耦合性降低，而且可以独立地改变它们之间的交互行为。
/// 
/// 优点：
/// 1.简化了对象之间的关系，将系统的各个对象之间的相互关系进行封装，将各个同事类解耦，使得系统变为松耦合。
/// 2.提供系统的灵活性，使得各个同事对象独立而易于复用。
/// 
/// 缺点：
/// 1.中介者模式中，中介者角色承担了较多的责任，所以一旦这个中介者对象出现了问题，整个系统将会受到重大的影响。
///   例如，QQ游戏中计算欢乐豆的程序出错了，这样会造成重大的影响。
/// 2.新增加一个同事类时，不得不去修改抽象中介者类和具体中介者类，此时可以使用观察者模式和状态模式来解决这个问题。
/// 
/// 应用场景：
/// 1.一组定义良好的对象，现在要进行复杂的相互通信。
/// 2.想通过一个中间类来封装多个类中的行为，而又不想生成太多的子类。
/// </remarks>
internal class Program
{
    private static void Main(string[] args)
    {
        var a = new ParterA();
        var b = new ParterB();

        //初始化
        a.MoneyCount = 20;
        b.MoneyCount = 20;

        var mediator = new MediatorPater(a, b);

        a.ChangeCount(5, mediator);
        Console.WriteLine($"A现在的钱是：{a.MoneyCount}");
        Console.WriteLine($"B现在的钱是：{b.MoneyCount}");

        b.ChangeCount(6, mediator);
        Console.WriteLine($"A现在的钱是：{a.MoneyCount}");
        Console.WriteLine($"B现在的钱是：{b.MoneyCount}");
    }
}
