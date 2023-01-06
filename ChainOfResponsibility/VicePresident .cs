namespace ChainOfResponsibility;

/// <summary>
/// 副总
/// </summary>
public class VicePresident : Approver
{
    public VicePresident(string name) : base(name) { }

    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount < 25000.0)
        {
            Console.WriteLine($"{this} - {Name} approved the request of purshing {request.ProductName}");
        }
        else if (NextApprover != null)
        {
            NextApprover.ProcessRequest(request);
        }
    }
}
