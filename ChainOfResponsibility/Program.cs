using ChainOfResponsibility;

var requestTelephone = new PurchaseRequest(4000.0, "Telephone");
var requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
var requestComputers = new PurchaseRequest(40000.0, "Computers");

Approver manager = new Manager("LearningHard");
Approver vp = new VicePresident("Tony");
Approver p = new President("BossTom");

//设置责任链
manager.NextApprover = vp;
vp.NextApprover = p;

//处理请求
manager.ProcessRequest(requestTelephone);
manager.ProcessRequest(requestSoftware);
manager.ProcessRequest(requestComputers);