namespace Stragety;

/// <summary>
/// 企业所得税
/// </summary>
public class EnterpriseTaxStrategy : ITaxStragety
{
    public double CalculateTax(double income) => (income - 3500) > 0 ? (income - 3500) * 0.045 : 0.0;
}
