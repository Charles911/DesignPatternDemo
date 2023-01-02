﻿namespace Bridge;

/// <summary>
/// 桥接模式
/// </summary>
/// <remarks>
/// 桥接模式即将抽象部分与实现部分脱耦，使它们可以独立变化。
/// 
/// 优点：
/// 1.把抽象接口与其实现解耦。
/// 2.抽象和实现可以独立扩展，不会影响到对方。
/// 3.实现细节对客户透明，对用于隐藏了具体实现细节。
/// 
/// 缺点：
/// 1.增加了系统的复杂度
/// 
/// 应用场景：
/// 1.如果一个系统需要在构件的抽象化角色和具体化角色之间添加更多的灵活性，避免在两个层次之间建立静态的联系。
/// 2.设计要求实现化角色的任何改变不应当影响客户端，或者实现化角色的改变对客户端是完全透明的。
/// 3.需要跨越多个平台的图形和窗口系统上。
/// 4.一个类存在两个独立变化的维度，且两个维度都需要进行扩展。
/// </remarks>
class Program
{
    static void Main(string[] args)
    {
        //以电视机遥控器的例子来演示
        //创建一个遥控器
        var remoteControl = new ConcreteRemote();

        //长虹电视机
        remoteControl.Implementor = new ChangHong();
        remoteControl.On();
        remoteControl.SetChannel();
        remoteControl.Off();

        Console.WriteLine();

        //三星电视机
        remoteControl.Implementor = new Samsung();
        remoteControl.On();
        remoteControl.SetChannel();
        remoteControl.Off();
    }
}
