namespace Template;

/// <summary>
/// 模板模式
/// </summary>
/// <remarks>
/// 优点：
/// 1.实现了代码复用
/// 2.能够灵活应对子步骤的变化，符合开放——封闭原则
/// 
/// 缺点：
/// 1.因为引入了一个抽象类，如果具体实现过多的话，需要用户或开发人员花费更多时间去理清类之间的关系。
/// 
/// 附：在.NET中模板方法的应用也很多，例如我们在开发自定义的Web控件或WinForm控件时，只需要重写某个控件的部分方法
/// </remarks>
internal class Program
{
    private static void Main(string[] args)
    {
        var spinach = new Spinach();
        spinach.CookVegetable();
    }
}
