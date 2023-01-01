namespace Adapter;
/// <summary>
/// 适配器模式
/// </summary>
/// <remarks>
/// 这里以插座和插头的例子来诠释适配器模式
/// 现在我们买的电器插头是2个孔，但是我们买的插座只有3个孔的
/// 这是我们想把电器插在插座上的话就需要一个电适配器
/// </remarks>
class Program
{
    /// <summary>
    /// 客户端，客户想要把2个孔的插头 转变成三个孔的插头，这个转变交给适配器就好
    /// 既然适配器需要完成这个功能，所以它必须同时具体2个孔插头和三个孔插头的特征
    /// </summary>
    static void Main(string[] args)
    {
        IThreeHole threeHole = new PowerAdapter();
        threeHole.Request();
    }
}
