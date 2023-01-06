﻿namespace ChainOfResponsibility;

/// <summary>
/// 责任链模式
/// </summary>
/// <remarks>
/// 某个请求需要多个对象进行处理，从而避免请求的发送者和接收之间的耦合关系。
/// 将这些对象连成一条链子，并沿着这条链子传递该请求，直到有对象处理它为止。
/// 
/// 优点：
/// 1.降低了请求的发送者和接收者之间的耦合。
/// 2.把多个条件判定分散到各个处理类中，使得代码更加清晰，责任更加明确。
/// 
/// 缺点：
/// 1.在找到正确的处理对象之前，所有的条件判定都要执行一遍，当责任链过长时，可能会引起性能的问题
/// 2.可能导致某个请求不被处理。
/// 
/// 应用场景：
/// 1.一个系统的审批需要多个对象才能完成处理的情况下，例如请假系统等。
/// 2.代码中存在多个if-else语句的情况下，此时可以考虑使用责任链模式来对代码进行重构。
/// </remarks>
class Program
{
    static void Main(string[] args)
    {
        var requestTelphone = new PurchaseRequest(4000.0, "Telphone");
        var requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
        var requestComputers = new PurchaseRequest(40000.0, "Computers");

        Approver manager = new Manager("LearningHard");
        Approver vp = new VicePresident("Tony");
        Approver p = new President("BossTom");

        //设置责任链
        manager.NextApprover = vp;
        vp.NextApprover = p;

        //处理请求
        manager.ProcessRequest(requestTelphone);
        manager.ProcessRequest(requestSoftware);
        manager.ProcessRequest(requestComputers);
    }
}
