namespace Builder;

/// <summary>
/// 抽象建造者，这个场景下为 "组装人" ，这里也可以定义为抽象类
/// </summary>
public interface IBuilder
{
    /// <summary>
    /// 装CPU
    /// </summary>
    void BuildPartCPU();

    /// <summary>
    /// 装主板
    /// </summary>
    void BuildPartMainBoard();

    /// <summary>
    /// 获得组装好的电脑
    /// </summary>
    /// <returns></returns>
    Computer GetComputer();
}
