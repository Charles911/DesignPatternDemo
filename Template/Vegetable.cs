namespace Template;

public abstract class Vegetable
{
    /// <summary>
    /// 不要把模板方法定义为virtual或abstract方法，避免被子类重写，防止更改流程的执行顺序
    /// </summary>
    public void CookVegetable(){
        Console.WriteLine("炒菜的一般做法");
        PourOil();
        HeatOil();
        PourVegetable();
        StirFry(); 
    }

    /// <summary>
    /// 第一步：倒油
    /// </summary>
    public void PourOil() => Console.WriteLine("倒油");
    
    /// <summary>
    /// 第二步：把油烧热
    /// </summary>
    public void HeatOil() => Console.WriteLine("把油烧热");

    /// <summary>
    /// 第三步：油热了之后倒蔬菜下去，具体哪种蔬菜由子类决定
    /// </summary>
    public abstract void PourVegetable();

    /// <summary>
    /// 第四步：开始翻炒
    /// </summary>
    public void StirFry() => Console.WriteLine("翻炒");
}