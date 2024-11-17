namespace ChainOfResponsibility;

/// <summary>
/// 总经理
/// </summary>
public class President(string name) : Approver(name)
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount < 100000.0)
        {
            Console.WriteLine($"{this} - {Name} approved the request of purshing {request.ProductName}");
        }
        else if (NextApprover != null)
        {
            Console.WriteLine("该请求需要组织一个会议讨论");
        }
    }
}
