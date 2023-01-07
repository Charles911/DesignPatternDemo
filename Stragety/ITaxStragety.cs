namespace Stragety;

/// <summary>
/// 所得税计算策略
/// </summary>
public interface ITaxStragety
{
    double CalculateTax(double income);
}
