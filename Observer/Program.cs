using Observer;

Tencent tenXun = new TencentGame("TenXun Game", "Have a new game published ....");

tenXun.AddObserver(new Subscriber("Learning Hard"));
tenXun.AddObserver(new Subscriber("Tom"));

tenXun.Update();