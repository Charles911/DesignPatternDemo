namespace Bridge;

/// <summary>

/// </remarks>
internal class Program
{
    private static void Main(string[] args)
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
