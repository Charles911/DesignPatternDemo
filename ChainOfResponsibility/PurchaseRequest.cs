namespace ChainOfResponsibility;

/// <summary>
/// 采购请求
/// </summary>
public class PurchaseRequest
{
    public PurchaseRequest(double amount, string productName)
    {
        Amount = amount;
        ProductName = productName;
    }

    /// <summary>
    /// 金额
    /// </summary>
    public double Amount{get; set;}

    /// <summary>
    /// 产品
    /// </summary>
    public string ProductName{get; set;}
}
