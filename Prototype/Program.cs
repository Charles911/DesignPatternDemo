using Prototype;

//孙悟空 原型
MonkeyKingPrototype prototypeMonkeyKing = new ConcretePrototype("MonkeyKing");

//变一个
var cloneMonkeyKing = prototypeMonkeyKing.Clone() as ConcretePrototype;
Console.WriteLine("Cloned1:\t" + cloneMonkeyKing!.Id);

//变两个
var cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as ConcretePrototype;
Console.WriteLine("Cloned2:\t" + cloneMonkeyKing2!.Id);