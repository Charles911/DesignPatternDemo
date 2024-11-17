namespace ChainOfResponsibility;

/// <summary>
/// 采购请求
/// </summary>
public class PurchaseRequest(double amount, string productName)
{

    /// <summary>
    /// 金额
    /// </summary>
    public double Amount { get; set; } = amount;

    /// <summary>
    /// 产品
    /// </summary>
    public string ProductName { get; set; } = productName;
}
