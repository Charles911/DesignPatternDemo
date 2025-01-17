using Mediator;

var a = new ParterA();
var b = new ParterB();

//初始化
a.MoneyCount = 20;
b.MoneyCount = 20;

var mediator = new MediatorPater(a, b);

a.ChangeCount(5, mediator);
Console.WriteLine($"A现在的钱是：{a.MoneyCount}");
Console.WriteLine($"B现在的钱是：{b.MoneyCount}");

b.ChangeCount(6, mediator);
Console.WriteLine($"A现在的钱是：{a.MoneyCount}");
Console.WriteLine($"B现在的钱是：{b.MoneyCount}");