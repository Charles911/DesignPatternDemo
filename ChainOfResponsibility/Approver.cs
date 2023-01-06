namespace ChainOfResponsibility;

/// <summary>
/// 审批人
/// </summary>
public abstract class Approver
{
    public Approver(string name)
    {
        Name = name;
    }

    public Approver? NextApprover { get; set; }
    public string Name { get; set; }

    public abstract void ProcessRequest(PurchaseRequest request);
}
