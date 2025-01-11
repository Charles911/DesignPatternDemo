using Adapter;

// 客户端，客户想要把2个孔的插头 转变成三个孔的插头，这个转变交给适配器就好
// 既然适配器需要完成这个功能，所以它必须同时具体2个孔插头和三个孔插头的特征

//类适配模式
new PowerAdapter().Request();

//对象适配模式
new PowerAdapter2().Request();