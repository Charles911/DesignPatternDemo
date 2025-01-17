using Command;

//初始化
var receiver = new Receiver();
var command = new ConcreteCommand(receiver);
var invoke = new Invoke(command);

//执行
invoke.Execute();