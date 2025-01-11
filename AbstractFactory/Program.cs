using AbstractFactory;

var af1 = new NanjingFactory();
var af2 = new ShanghaiFactory();

var sYb = af2.CreateYabo();
var nYb = af1.CreateYabo();
var sYj = af2.CreateYajia();
var nYj = af1.CreateYajia();

sYb.Show();
nYb.Show();
sYj.Show();
nYj.Show();