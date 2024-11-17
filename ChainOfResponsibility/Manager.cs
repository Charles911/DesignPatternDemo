namespace ChainOfResponsibility;

/// <summary>
/// 经理
/// </summary>
public class Manager(string name) : Approver(name)
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount < 10000.0)
        {
            Console.WriteLine($"{this} - {Name} approved the request of purshing {request.ProductName}");
        }
        else
        {
            NextApprover?.ProcessRequest(request);
        }
    }
}
