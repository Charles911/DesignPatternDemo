namespace ChainOfResponsibility;

/// <summary>
/// 审批人
/// </summary>
public abstract class Approver(string name)
{
    public Approver? NextApprover { get; set; }
    public string Name { get; set; } = name;

    public abstract void ProcessRequest(PurchaseRequest request);
}
