namespace Stragety;

/// <summary>
/// 策略模式
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //个人所得税
        InterestOperation operation = new(new PersonalTaxStrategy());
        Console.WriteLine($"个人支付的税为：{operation.GetTax(5000.00)}");

        //企业所得税
        operation = new(new EnterpriseTaxStrategy());
        Console.WriteLine($"企业支付的税为：{operation.GetTax(50000.00)}");
    }
}
