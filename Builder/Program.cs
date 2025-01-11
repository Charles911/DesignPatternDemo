using Builder;

//客户找到电脑城老板说要买电脑，这里要装两台电脑
//创建指挥者和构造者
var director = new Director();
var builder1 = new ConcreteBuilder1();
var builder2 = new ConcreteBuilder2();

//老板叫员工去组装第一台电脑
director.Construct(builder1);

//组装完，组装人员搬来组装好的电脑
var computer1 = builder1.GetComputer();
computer1.Show();

//老板叫员工去组装第二台电脑
director.Construct(builder2);

//组装完，组装人员搬来组装好的电脑
var computer2 = builder2.GetComputer();
computer2.Show();