namespace Stragety;

/// <summary>
/// 个人所得税
/// </summary>
public class PersonalTaxStrategy : ITaxStragety
{
    public double CalculateTax(double income) => income * 0.12;
}
